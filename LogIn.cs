using MySql.Data.MySqlClient;
using WInstonKingC969.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WInstonKingC969
{
    public partial class LogIn : Form
    {
        
        
        public LogIn()
        {
            InitializeComponent();

            
            //Should switch languages if region detected on login
            if (RegionInfo.CurrentRegion.DisplayName == "Mexico")
            //if (CultureInfo.CurrentUICulture.LCID == 2058)
            {

                usernameLbl.Text = "Nombre de usuario";
                passwordLbl.Text = "Contraseña";
                signInBtn.Text = "Iniciar sesión";
                exitBtn.Text = "Cancelar";
               // errorLbl.Text = "El nombre de usuario y la contraseña no son correctos";

            }


        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From user where userName = '" + usernameTxt.Text + "' and password = '" + passwordTxt.Text + "'", connect);
                DataTable loginDt = new DataTable();
                adapter.Fill(loginDt);

                if (loginDt.Rows.Count > 0)
                {

                    WriteLogin();
                    CheckAppt();

                    this.Hide();
                    UserDashboard dash = new UserDashboard();
                    dash.Show();
                }
                else
                {

                    if (RegionInfo.CurrentRegion.DisplayName == "Mexico")
                    //if (CultureInfo.CurrentUICulture.LCID == 2058)

                    {
                        errorLbl.Text = "El nombre de usuario o la contraseña no son correctos.";

                    }
                    else
                    {
                        errorLbl.Text = "The username or password are incorrect.";
                    }

                }
            }
            UniversalCode.GetCurrentUserName();
            UniversalCode.GetCurrentUserID();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
          
        }

       
        private void WriteLogin()
        {
            try
            {
                //This will keep login record for login report. looks for record, if exists writes, if not, creates
               
                if (File.Exists("loginRecord.txt"))
                {
                    using (StreamWriter e = File.AppendText("loginRecord.txt"))
                    {
                        e.WriteLine(usernameTxt.Text + " finally decided to go to work ;) at " + DateTime.Now.ToString(), e);
                    }
                }
               
                else
                {
                    using (StreamWriter logUser = new StreamWriter("loginRecord.txt"))
                    {
                        logUser.WriteLine(usernameTxt.Text + " finally decided to go to work ;) at " + DateTime.Now.ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        //15 min appointmnet alert. Checks and alerts user of upcoming appointmnet apon login if sheduled to begin within 15 min. 
        private void CheckAppt()
        {
            DateTime Current = Convert.ToDateTime(DateTime.UtcNow);
            DateTime Future = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

            DataTable upcoming = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
            {
                connect.Open();
                MySqlCommand apptCheck = new MySqlCommand("SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.start, appointment.end from appointment INNER JOIN customer on appointment.customerId = customer.customerId where start BETWEEN '" +
                    Current.ToString("yyyy-MM-dd HH:mm") + "' AND '" +
                    Future.ToString("yyyy-MM-dd HH:mm") + "';", connect);
                MySqlDataReader apptRead = apptCheck.ExecuteReader();
                upcoming.Load(apptRead);

                if (upcoming.Rows.Count > 0)
                {
                    for (int i = 0; i < upcoming.Rows.Count; i++)
                    {
                        MessageBox.Show("Reminder", "You have an appointment with " + upcoming.Rows[i]["customerName"] + " within the next 15 minutes.");
                    }
                }
                connect.Close();
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

