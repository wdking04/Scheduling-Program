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
    public partial class MyScheduleReport : Form
    {
        string getUsers = "SELECT userName from user;";
        int userId;

        public MyScheduleReport()
        {
            InitializeComponent();
            DataTable users = new DataTable();
            UniversalCode.GetData(getUsers, users);
            userCB.DataSource = users;
            userCB.DisplayMember = "userName";
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            GetUserSchedules();

           
        }

        private void GetUserSchedules()
        {
            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                string userName = userCB.GetItemText(userCB.Text);
                string getUserId = "SELECT userId FROM user WHERE userName = '" + userName + "';";

                connect.Open();
                DataTable userIds = new DataTable();
                MySqlCommand cmd = new MySqlCommand(getUserId, connect);
                MySqlDataReader idReader = cmd.ExecuteReader();
                userIds.Load(idReader);

                if (userIds.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(userIds.Rows[0][0]);
                    userId = id;
                }

                string getSchedule = "SELECT customerId, type, start, end FROM appointment WHERE userId = '" + userId + "' ORDER BY start;";

                DataTable schedule = new DataTable();
                MySqlCommand populateSched = new MySqlCommand(getSchedule, connect);
                MySqlDataReader schedReader = populateSched.ExecuteReader();
                schedule.Load(schedReader);

                if (schedule.Rows.Count > 0)
                {
                    userDgv.DataSource = schedule;
                }

                connect.Close();
            }
        }

        private void UserSchedule_Load(object sender, EventArgs e)
        {
            GetUserSchedules();
        }

        private void returnMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyReports myReports = new MyReports();
            myReports.Show();
        }

        private void userCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void userDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

