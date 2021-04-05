using System;
using System.IO;
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
    public partial class LoginReport : Form
    {
        public LoginReport()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyReports myReports = new MyReports();
            myReports.Show();
        }

        private void createReportBtn_Click(object sender, System.EventArgs e)
        {

            try
            {
                string line;


                using (StreamReader sr = new StreamReader("loginRecord.txt"))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        logHistoryTextBox1.AppendText(line);
                        logHistoryTextBox1.AppendText("\r\n");
                        line = sr.ReadLine();

                    }
                    sr.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }

        private void logHistoryTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInReports_Load(object sender, EventArgs e)
        {

        }



        private void LoginReport_Load(object sender, EventArgs e)
        {

        }
    }
}
