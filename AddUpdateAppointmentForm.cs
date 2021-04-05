using MySql.Data.MySqlClient;
using WInstonKingC969.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInstonKingC969
{
    public partial class AddUpdateAppointmentForm : Form
    {

   
        public AddUpdateAppointmentForm()
        {
            string customerName = "SELECT customerName from customer;";
    
            DataTable customers = new DataTable();
            DataTable type = new DataTable();

            InitializeComponent();

            UniversalCode.GetData(customerName, customers);

            customerCB.DataSource = customers;
            customerCB.DisplayMember = "customerName";

           


            if (UniversalCode.AppointmentID > 0)
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    DataTable AppointmentFill = new DataTable();
                    string appointmentInfo = Appointment.apptQuery;

                    connect.Open();
                    MySqlCommand appointmentcmd = new MySqlCommand(appointmentInfo, connect);
                    MySqlDataReader areader = appointmentcmd.ExecuteReader();
                    AppointmentFill.Load(areader);

                    customerCB.Text = (string)AppointmentFill.Rows[UniversalCode.CurrentApptIndex]["customerName"];
                    typeCB.Text = (string)AppointmentFill.Rows[UniversalCode.CurrentApptIndex]["type"];
                    startTimePicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentFill.Rows[UniversalCode.CurrentApptIndex]["start"], TimeZoneInfo.Local);
                    endTimePicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentFill.Rows[UniversalCode.CurrentApptIndex]["end"], TimeZoneInfo.Local);
                    connect.Close();
                }
            }
        }
        private void cancelAppointmentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dash = new UserDashboard();
            dash.Show();
        }
        private void saveAppointmentBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Text = "";
            if (HourCheck() != false)
            {

                if (UniversalCode.AppointmentID > 0)
                {
                    UpdateAppointment();
                }
                else
                {
                    InsertAppointment();
                }
            }
        }

        
        private bool isOverlap(DateTime currentStart, DateTime currentEnd, DateTime scheduledStart, DateTime scheduledEnd)
        {
            
            return (currentStart < scheduledStart) ? (currentEnd < scheduledStart) ? false : true : (currentStart > scheduledEnd) ? false : true;
        }

        private void InsertAppointment()
        {
            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {

                try
                {
                    connect.Open();

                    DataTable overlap = new DataTable();
                    string getAllAppointments = "SELECT appointmentId, customerId, type, start, end FROM appointment;";

                    DateTime currentStart = TimeZoneInfo.ConvertTimeToUtc(startTimePicker.Value);
                    DateTime currentEnd = TimeZoneInfo.ConvertTimeToUtc(endTimePicker.Value);

                    MySqlCommand cmd = new MySqlCommand(getAllAppointments, connect);
                    MySqlDataReader compare = cmd.ExecuteReader();
                    overlap.Load(compare);

                    if (overlap.Rows.Count > 0)
                    {
                        for (int j = 0; j < overlap.Rows.Count; j++)
                        {

                            
                            DateTime scheduledStart = Convert.ToDateTime(overlap.Rows[j]["start"]);
                            DateTime scheduledEnd = Convert.ToDateTime(overlap.Rows[j]["end"]);

                            if (isOverlap(currentStart, currentEnd, scheduledStart, scheduledEnd))

                            {
                                errorLbl.Text = "Not available. Please choose another time."; // conflicting appointment times
                            }
                        }
                    }
                    if (UniversalCode.IsNotNullOrEmpty(errorLbl.Text))
                    {

                    }
                    else
                    {

                        string getCustomer = customerCB.GetItemText(customerCB.Text);
                        string getType = typeCB.GetItemText(typeCB.Text);
                        string getStart = TimeZoneInfo.ConvertTimeToUtc(startTimePicker.Value).ToString("yyyy-MM-dd HH:mm");
                        string getEnd = TimeZoneInfo.ConvertTimeToUtc(endTimePicker.Value).ToString("yyyy-MM-dd HH:mm");

                        string sql = "SELECT customerId FROM customer WHERE customerName = '" + getCustomer + "';";

                        MySqlCommand customer = new MySqlCommand(sql, connect);
                        MySqlDataAdapter customerAdapter = new MySqlDataAdapter(customer);
                        DataTable customerResult = new DataTable();
                        customerAdapter.Fill(customerResult);
                        if (customerResult.Rows.Count > 0)
                        {
                            int custID = Convert.ToInt32(customerResult.Rows[0][0]);
                            UniversalCode.CustomerID = custID;
                        }

                        //SQL query for appointment data
                        string insertAppointment = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) " +
                            "VALUES ('" + UniversalCode.CustomerID + "', '" + UniversalCode.CurrentUserID + "', 'not needed', 'not needed', 'not needed', 'not needed', '" + getType + "', 'not needed', '" + getStart + "', '" + getEnd + "', '" +
                            TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm") + "', '" + UniversalCode.CurrentUser + "', '" + UniversalCode.CurrentUser + "');";

                        MySqlCommand insertAppointmentData = new MySqlCommand(insertAppointment, connect);

                        insertAppointmentData.ExecuteNonQuery();
                        connect.Close();
                        this.Hide();
                        UserDashboard dash = new UserDashboard();
                        dash.Show();

                        MessageBox.Show("Appointment created.");
                        Close();
                    }
                }
                catch (Exception)
                {
                   
                    errorLbl.Text = "Error. Please try again.";
                }

               
            }

        }



        private void UpdateAppointment()
        {
            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                try
                {
                    connect.Open();

                    DataTable overlap = new DataTable();
                    string getAllAppointments = "SELECT appointmentId, customerId, type, start, end FROM appointment;";

                    DateTime currentStart = TimeZoneInfo.ConvertTimeToUtc(startTimePicker.Value);
                    DateTime currentEnd = TimeZoneInfo.ConvertTimeToUtc(endTimePicker.Value);

                    MySqlCommand cmd = new MySqlCommand(getAllAppointments, connect);
                    MySqlDataReader compare = cmd.ExecuteReader();
                    overlap.Load(compare);

                    if (overlap.Rows.Count > 0)
                    {
                        for (int j = 0; j < overlap.Rows.Count; j++)
                        {
                            DateTime scheduledStart = Convert.ToDateTime(overlap.Rows[j]["start"]);
                            DateTime scheduledEnd = Convert.ToDateTime(overlap.Rows[j]["end"]);

                            if (isOverlap(currentStart, currentEnd, scheduledStart, scheduledEnd))

                                {
                                    errorLbl.Text = "Not available. Please choose another time."; // conflicting appointment times
                                }

                            //((DateTime.Compare(currentStart, scheduledStart) == 0) &&
                            // (DateTime.Compare(currentEnd, scheduledEnd) == 0))


                            //{
                            //    errorLbl.Text = "Not available. Please choose another time."; // conflicting appointment times
                            //}
                        }
                    }
                    if (UniversalCode.IsNotNullOrEmpty(errorLbl.Text))
                    {

                    }
                    else
                    {
                        string getCustomer = customerCB.GetItemText(customerCB.Text);
                        string getType = typeCB.GetItemText(typeCB.Text);
                        string getStart = TimeZoneInfo.ConvertTimeToUtc(startTimePicker.Value).ToString("yyyy-MM-dd HH:mm");
                        string getEnd = TimeZoneInfo.ConvertTimeToUtc(endTimePicker.Value).ToString("yyyy-MM-dd HH:mm");

                        string sql = "SELECT customerId FROM customer WHERE customerName = '" + getCustomer + "';";

                        MySqlCommand getCustomerId = new MySqlCommand(sql, connect);
                        MySqlDataAdapter customerAdapter = new MySqlDataAdapter(getCustomerId);
                        DataTable customerIdResult = new DataTable();
                        customerAdapter.Fill(customerIdResult);
                        if (customerIdResult.Rows.Count > 0)
                        {
                            int customerid = Convert.ToInt32(customerIdResult.Rows[0][0]);
                            UniversalCode.CustomerID = customerid;
                        }

                        // SQL query to appUpdate appointment
                        string updateAppointment = "UPDATE appointment SET customerId = '" + UniversalCode.CustomerID + "', userId = '" + UniversalCode.CurrentUserID +
                            "', title = 'not needed', description = 'not needed', location = 'not needed', contact = 'not needed', type = '" + getType +
                            "', url = 'not needed', start = '" + getStart + "', end = '" + getEnd + "', lastUpdate = '" +
                            TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:") + "', lastUpdateBy ='" + UniversalCode.CurrentUser + "'" +
                            " WHERE appointmentID = '" + UniversalCode.AppointmentID + "';";

                        MySqlCommand appUpdate = new MySqlCommand(updateAppointment, connect);
                        appUpdate.ExecuteNonQuery();
                        connect.Close();

                        this.Hide();
                        UserDashboard dash = new UserDashboard();
                        dash.Show();

                        MessageBox.Show("Appointment Updated.");
                        Close();
                    }
                }

                catch (Exception)
                {
                    
                    errorLbl.Text = "Error.Please try again.";
                }

                
            }
        }

        //Checks time to allow scheduling of appointments only between 8 and 5(normal operating hours)

        private bool HourCheck()
        {
            TimeSpan open = new TimeSpan(8, 0, 0);
            TimeSpan close = new TimeSpan(17, 1, 0);

            TimeSpan appointmentStart = startTimePicker.Value.TimeOfDay;
            TimeSpan appointmentEnd = endTimePicker.Value.TimeOfDay;

            if (appointmentStart < open || appointmentEnd > close)
            {
                errorLbl.Text = "Please schedule between 8am and 5pm.";
                return false;
            }
            else
            {
                return true;
            }

        }

        private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddUpdateAppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
