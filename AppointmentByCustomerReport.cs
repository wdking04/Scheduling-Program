using WInstonKingC969.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WInstonKingC969
{
    public partial class AppointmentByCustomerReport : Form
    {
        string customers = "SELECT customerName from customer;";
        int CustomerID;

        public AppointmentByCustomerReport()
        {
            InitializeComponent();
            DataTable customerList = new DataTable();
            UniversalCode.GetData(customers, customerList);
            customerCB.DataSource = customerList;
            customerCB.DisplayMember = "customerName";

            

        }

        private void customerCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void populateAppointments()
        {
            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();
                string customerName = customerCB.GetItemText(customerCB.Text);
                string sql = "SELECT customerId from customer where customerName = '" + customerName + "';";


                DataTable customerId = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader customerReader = cmd.ExecuteReader();
                customerId.Load(customerReader);

                if (customerId.Rows.Count == 1)
                {
                    int custId = (int)customerId.Rows[0][0];
                    CustomerID = custId;
                }

                string getAppointments = "SELECT  appointmentId, type, start, end FROM appointment WHERE customerId = '" + CustomerID + "';";

                DataTable appointments = new DataTable();
                MySqlCommand appointmentCommand = new MySqlCommand(getAppointments, connect);
                MySqlDataReader appointmentReader = appointmentCommand.ExecuteReader();
                appointments.Load(appointmentReader);

                appointmentByCustomerDgv.DataSource = appointments;

                connect.Close();

            }
        }

        private void createReportBtn_Click(object sender, EventArgs e)
        {
            populateAppointments();
        }

        private void returnDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyReports myReports = new MyReports();
            myReports.Show();
        }

        private void AppointmentByCustomer_Load(object sender, EventArgs e)
        {
            populateAppointments();
        }

        private void appointmentByCustomerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
