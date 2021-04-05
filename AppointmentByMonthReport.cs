using WInstonKingC969.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WInstonKingC969
{
    public partial class AppointmentByMonthReport : Form
    {
        string date;


        public AppointmentByMonthReport()
        {
            //Months to select from in combobox 

            InitializeComponent();
            monthCB.Items.Add("Jan 2020");
            monthCB.Items.Add("Feb 2020");
            monthCB.Items.Add("March 2020");
            monthCB.Items.Add("April 2020");
            monthCB.Items.Add("May 2020");
            monthCB.Items.Add("June 2020");
            monthCB.Items.Add("July 2020");
            monthCB.Items.Add("Aug 2020");
            monthCB.Items.Add("Sep 2020");
            monthCB.Items.Add("Oct 2020");
            monthCB.Items.Add("Nov 2020");
            monthCB.Items.Add("Dec 2020");

        }

        //Months to get appointment totals for report
        private void createReportBtn_Click(object sender, EventArgs e)
        {
            if (monthCB.GetItemText(monthCB.Text) == "Jan 2020")
            {
                date = "2020-01%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Feb 2020")
            {
                date = "2020-02%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "March 2020")
            {
                date = "2020-03%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "April 2020")
            {
                date = "2020-04%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "May 2020")
            {
                date = "2020-05%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "June 2020")
            {
                date = "2020-06%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "July 2020")
            {
                date = "2020-07%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Aug 2020")
            {
                date = "2020-08%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Sep 2020")
            {
                date = "2020-09%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Oct 2020")
            {
                date = "2020-10%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Nov 2020")
            {
                date = "2020-11%";
            }
            else if (monthCB.GetItemText(monthCB.Text) == "Dec 2020")
            {
                date = "2020-12%";
            }
            else
            {
                MessageBox.Show("Please select a month.");
            }

            //FInds date and individual types of appointments

            string selectAllAppointmentsMonth = "SELECT  type, start FROM appointment WHERE start LIKE '" + date + "';";

            string selectFollowUpAppoinmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Follow Up';";

            string selectInitialAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Initial';";

            string selectPresentationAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Presentation';";

            string selectScrumAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Scrum';";

            string selectOtherAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Other';";

            string selectAppointmentCountMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "';";

            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();
                MySqlCommand allAppointments = new MySqlCommand(selectAllAppointmentsMonth, connect);
                MySqlCommand followUpAppointments = new MySqlCommand(selectFollowUpAppoinmentMonth, connect);
                MySqlCommand initialAppointments = new MySqlCommand(selectInitialAppointmentMonth, connect);
                MySqlCommand scrumAppointments = new MySqlCommand(selectScrumAppointmentMonth, connect);
                MySqlCommand otherAppointments = new MySqlCommand(selectOtherAppointmentMonth, connect);
                MySqlCommand presAppointments = new MySqlCommand(selectPresentationAppointmentMonth, connect);
                MySqlCommand allCount = new MySqlCommand(selectAppointmentCountMonth, connect);

                DataTable allAppointmentsDt = new DataTable();
                MySqlDataReader reader = allAppointments.ExecuteReader();
                allAppointmentsDt.Load(reader);
                appointmentByMonthDgv.DataSource = allAppointmentsDt;
                //appointmentByMonthDgv.Columns["appointmentId"].Visible = false;
                //appointmentByMonthDgv.Columns["customerId"].Visible = false;


                DataTable initial = new DataTable();
                MySqlDataReader initialReader = initialAppointments.ExecuteReader();
                initial.Load(initialReader);
                initialCount.Text = initial.Rows[0][0].ToString();

                DataTable followUp = new DataTable();
                MySqlDataReader followUpReader = followUpAppointments.ExecuteReader();
                followUp.Load(followUpReader);
                followUpCount.Text = followUp.Rows[0][0].ToString();

                DataTable scrum = new DataTable();
                MySqlDataReader scrumReader = scrumAppointments.ExecuteReader();
                scrum.Load(scrumReader);
                scrumCount.Text = scrum.Rows[0][0].ToString();

                DataTable other = new DataTable();
                MySqlDataReader otherReader = otherAppointments.ExecuteReader();
                other.Load(otherReader);
                otherCount.Text = other.Rows[0][0].ToString();

                DataTable presentation = new DataTable();
                MySqlDataReader presReader = presAppointments.ExecuteReader();
                presentation.Load(presReader);
                presentationCount.Text = presentation.Rows[0][0].ToString();

                DataTable all = new DataTable();
                MySqlDataReader allTypeCount = allCount.ExecuteReader();
                all.Load(allTypeCount);
                totalCount.Text = all.Rows[0][0].ToString();

                connect.Close();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyReports myReports = new MyReports();
            myReports.Show();
        }

        private void followUpLbl_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentByMonth_Load(object sender, EventArgs e)
        {

        }

        private void initialLbl_Click(object sender, EventArgs e)
        {

        }

        private void appointmentByMonthDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
