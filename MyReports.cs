using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInstonKingC969
{
    public partial class MyReports : Form
    {
        public MyReports()
        {
            InitializeComponent();
        }

        private void myReportsLbl_Click(object sender, EventArgs e)
        {

        }

        private void appointmentsByMonthBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentByMonthReport monReport = new AppointmentByMonthReport();
            monReport.Show();
        }

        private void userScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyScheduleReport userSched = new MyScheduleReport();
            userSched.Show();
        }

        private void appointmentByCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentByCustomerReport custReport = new AppointmentByCustomerReport();
            custReport.Show();
        }

        private void returnToDashBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dash = new UserDashboard();
            dash.Show();
        }

        private void MyReports_Load(object sender, EventArgs e)
        {

        }

        private void myActivityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginReport logReport = new LoginReport();
            logReport.Show();

        }

        
    }
}
