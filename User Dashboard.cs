using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using WInstonKingC969.Universal;

namespace WInstonKingC969
{
    public partial class UserDashboard : Form
    {
        public delegate string ExitDashboard(string name);
        public delegate string CustomerDeleted(string name);
        public delegate string AppDeleted(string name);
        DataTable customerDataTable = new DataTable();
        DataTable appointmentDataTable = new DataTable();
        DateTime selectedDate = new DateTime();



        public UserDashboard()
        {
            InitializeComponent();

            selectedDate = DateTime.Now;
            myCal.AddBoldedDate(selectedDate);
            

           // Populate data grid views

            UniversalCode.CurrentCustIndex = -1;
            Customer.populateCustomerData(Customer.findAllCustQuery, customerDataTable);
            customerDgv.RowHeadersVisible = false;
            customerDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDgv.DefaultCellStyle.SelectionForeColor = customerDgv.DefaultCellStyle.ForeColor;
            customerDgv.DataSource = customerDataTable;
            customerDgv.Columns["country"].Visible = true;
            customerDgv.Columns["customerId"].Visible = false;
            UniversalCode.CurrentApptIndex = -1;
            Appointment.populateAppointmentData(Appointment.apptQuery, appointmentDataTable);
            appointmentDgv.RowHeadersVisible = false;
            appointmentDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDgv.DefaultCellStyle.SelectionForeColor = appointmentDgv.DefaultCellStyle.ForeColor;
            appointmentDgv.DataSource = appointmentDataTable;
            appointmentDgv.Columns["customerId"].Visible = false;
            appointmentDgv.Columns["appointmentId"].Visible = false;

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            UniversalCode.CustomerID = 0;
            this.Hide();
            AddUpdateCustomerForm newCustomer = new AddUpdateCustomerForm();
            newCustomer.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(" Please confirm you wish to EXIT the user dashboard", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //lambda expression used to create a message thanking user for using application
                ExitDashboard obj = (currentUserName) => {
                    return "Thank you for your hard work and dedication." +
                " Have a GREAT day!";
                };

                string ExitDashboard = obj.Invoke(UniversalCode.CurrentUser);
                MessageBox.Show(ExitDashboard);
                Application.Exit();
            }
        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            UniversalCode.CustomerID = 0;
            UniversalCode.AppointmentID = 0;
            this.Hide();
            AddUpdateAppointmentForm newAppointment = new AddUpdateAppointmentForm();
            newAppointment.Show();
        }

        private void dayRb_CheckedChanged(object sender, EventArgs e)
        {
            HandleDay();
        }

        private void weeklyRb_CheckedChanged(object sender, EventArgs e)
        {
            HandleWeek();
        }

        private void monthlyRb_CheckedChanged(object sender, EventArgs e)
        {
            HandleMonth();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (UniversalCode.CurrentCustIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer;", connect);
                    MySqlDataReader customerid = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(customerid);
                    if (dt.Rows.Count > 0)
                    {
                        int custId = (int)dt.Rows[UniversalCode.CurrentCustIndex]["customerId"];
                        UniversalCode.CustomerID = custId;
                    }
                    connect.Close();
                }
                this.Hide();
                AddUpdateCustomerForm editCust = new AddUpdateCustomerForm();
                editCust.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }
        private void udpateAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (UniversalCode.CurrentApptIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * from appointment;", connect);
                    MySqlDataReader appointmentid = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(appointmentid);
                    if (dt.Rows.Count > 0)
                    {
                        int appointId = (int)dt.Rows[UniversalCode.CurrentApptIndex]["appointmentId"];
                        UniversalCode.AppointmentID = appointId;
                    }
                    connect.Close();
                }
                this.Hide();
                AddUpdateAppointmentForm editAppt = new AddUpdateAppointmentForm();
                editAppt.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }
        private void customerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UniversalCode.CurrentCustIndex = e.RowIndex;
            customerDgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;

        }
        private void appointmentDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UniversalCode.CurrentApptIndex = e.RowIndex;
            appointmentDgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;

        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (UniversalCode.CurrentCustIndex >= 0)
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(Customer.findAllCustQuery, connect);
                    MySqlDataReader customerReader = cmd.ExecuteReader();
                    DataTable deleteCustomer = new DataTable();
                    deleteCustomer.Load(customerReader);

                    UniversalCode.CustomerID = (int)deleteCustomer.Rows[UniversalCode.CurrentCustIndex]["customerId"];

                    MySqlCommand acmd = new MySqlCommand("SELECT addressId from customer WHERE customerId = '" + UniversalCode.CustomerID + "';", connect);
                    MySqlDataReader addReader = acmd.ExecuteReader();
                    DataTable deleteAddress = new DataTable();
                    deleteAddress.Load(addReader);

                    UniversalCode.AddressID = (int)deleteAddress.Rows[0][0];

                    if (UniversalCode.CustomerID != 0)
                    {
                        string deleteCustomerAndAddress = "DELETE customer FROM customer WHERE customerId = '" + UniversalCode.CustomerID + "';" +
                            "DELETE address FROM address WHERE addressId = '" + UniversalCode.AddressID + "';";

                        MySqlCommand completeDelete = new MySqlCommand(deleteCustomerAndAddress, connect);
                        DialogResult dialogResult = MessageBox.Show("Customer will be permanently deleted. Do you wish to continue?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                {
                                    completeDelete.ExecuteNonQuery();
                                    DataTable customerDeleteCompleted = new DataTable();
                                    UniversalCode.GetData(Customer.findAllCustQuery, customerDeleteCompleted);
                                    customerDgv.DataSource = customerDeleteCompleted;

                                    //lambda expression used to let user know customer was deleted
                                    CustomerDeleted obj = (currentUserName) => { return "Customer permanently deleted."; };
                                    string CustomerDeleted = obj.Invoke(UniversalCode.CurrentUser);
                                    MessageBox.Show(CustomerDeleted);

                                }
                            }
                            catch
                            {

                                MessageBox.Show("Unable to delete. Customer has upcoming appointmet(s) scheduled. Please delete customer appointment(s) and try again.");
                            }
                        }
                        connect.Close();
                    }
                }


            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (UniversalCode.CurrentApptIndex > 0)
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(Appointment.apptQuery, connect);
                    MySqlDataReader apptointmentReader = cmd.ExecuteReader();
                    DataTable deleteAppointment = new DataTable();
                    deleteAppointment.Load(apptointmentReader);

                    UniversalCode.AppointmentID = (int)deleteAppointment.Rows[UniversalCode.CurrentApptIndex]["appointmentId"];

                    if (UniversalCode.AppointmentID != 0)
                    {
                        string deleteSelectedAppointment = "DELETE appointment FROM appointment WHERE appointmentId = '" + UniversalCode.AppointmentID + "';";

                        MySqlCommand delete = new MySqlCommand(deleteSelectedAppointment, connect);
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this appointment?", "", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            delete.ExecuteNonQuery();
                            this.Hide();
                            UserDashboard dash = new UserDashboard();
                            dash.Show();

                            //lambda expression used to let user know appointment deleted
                            AppDeleted obj = (currentUserName) => { return "Appointment permanently deleted"; };
                            string AppointmentDeleted = obj.Invoke(UniversalCode.CurrentUser);
                            MessageBox.Show(AppointmentDeleted);
                            
                        }
                    }
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        //User Calender
        private void HandleDay()
        {
            myCal.MaxSelectionCount = 1;
            DateTime dayStart = new DateTime();
            DateTime dayEnd = new DateTime();

            dayStart = selectedDate;
            dayEnd = selectedDate.AddDays(1);

            myCal.SetSelectionRange(dayStart, dayEnd);

            string todayAppt = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN  '" +
                TimeZoneInfo.ConvertTimeToUtc(dayStart).ToString("yyyy-MM-dd HH:mm") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(dayEnd).ToString("yyyy-MM-dd HH:mm") + "' ;";

            DataTable handleDay = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(todayAppt, connect);
                MySqlDataReader dayReader = cmd.ExecuteReader();
                handleDay.Load(dayReader);

                if (handleDay.Rows.Count > 0)
                {
                    for (int i = 0; i < handleDay.Rows.Count; i++)
                    {
                        appointmentDgv.DataSource = handleDay;
                        handleDay.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["start"],
                            TimeZoneInfo.Local).ToString();
                        handleDay.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found for this date.");
                }
                connect.Close();
            }
        }

        private void HandleWeek()
        {
            myCal.MaxSelectionCount = 7;
            DateTime weekStart = new DateTime();
            DateTime weekEnd = new DateTime();

            weekStart = selectedDate;
            weekEnd = selectedDate.AddDays(7);
            myCal.SetSelectionRange(weekStart, weekEnd);

            string weekAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" +
                TimeZoneInfo.ConvertTimeToUtc(weekStart).ToString("yyyy-MM-dd HH:mm") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(weekEnd).ToString("yyyy-MM-dd HH:mm") + "' ;";

            DataTable handleWeek = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(weekAppts, connect);
                MySqlDataReader weekReader = cmd.ExecuteReader();
                handleWeek.Load(weekReader);

                if (handleWeek.Rows.Count > 0)
                {
                    for (int i = 0; i < handleWeek.Rows.Count; i++)
                    {
                        appointmentDgv.DataSource = handleWeek;
                        handleWeek.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["start"],
                            TimeZoneInfo.Local).ToString();
                        handleWeek.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found for this date range.");
                }
                connect.Close();
            }
        }

        private void HandleMonth()
        {
            myCal.MaxSelectionCount = 31;
            DateTime monthStart = new DateTime();
            DateTime monthEnd = new DateTime();
            monthStart = selectedDate;
            monthEnd = selectedDate.AddDays(31);
            myCal.SetSelectionRange(monthStart, monthEnd);

            string monthAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" +
                    TimeZoneInfo.ConvertTimeToUtc(monthStart).ToString("yyyy-MM-dd HH:mm") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(monthEnd).ToString("yyyy-MM-dd HH:mm") + "' ;";

            DataTable handleMon = new DataTable();
            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();

                MySqlCommand populateDt = new MySqlCommand(monthAppts, connect);
                MySqlDataReader readMonthAppts = populateDt.ExecuteReader();
                handleMon.Load(readMonthAppts);
                if (handleMon.Rows.Count > 0)
                {
                    //convert start and end times from UTC
                    for (int i = 0; i < handleMon.Rows.Count; i++)
                    {
                        appointmentDgv.DataSource = handleMon;
                        handleMon.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["start"],
                            TimeZoneInfo.Local).ToString();
                        handleMon.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["end"],
                            TimeZoneInfo.Local).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No appointments found.");
                }
                connect.Close();
            }
        }
        private void myCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
            if (monthlyRb.Checked)
            {
                HandleMonth();
            }
            else
            {
                if (weeklyRb.Checked)
                {
                    HandleWeek();
                }
                else
                {
                    HandleDay();
                }
            }
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyReports myReports = new MyReports();
            myReports.Show();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void myCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void appointmentDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

