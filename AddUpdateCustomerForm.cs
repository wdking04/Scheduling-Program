using WInstonKingC969.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WInstonKingC969
{
    public partial class AddUpdateCustomerForm : Form
    {

        
        private bool SaveAllowed()
        {
            if (!UniversalCode.IsNotNullOrEmpty(nameTxt.Text))
            { return false; }
            if (!UniversalCode.IsNotNullOrEmpty(addressTxt.Text))
            { return false; }
            if (!UniversalCode.IsNotNullOrEmpty(zipTxt.Text))
            { return false; }
            if (!UniversalCode.IsNotNullOrEmpty(phoneTxt.Text))
            { return false; }
            return true;
        }
        public AddUpdateCustomerForm()
        {
           
            DataTable cityDt = new DataTable();
            InitializeComponent();
          
            cityCB.DisplayMember = "City";


            if (UniversalCode.CustomerID > 0)
            {
                DataTable customerFill = new DataTable();
                string custInfo = Customer.findAllCustQuery;


                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    MySqlCommand ccmd = new MySqlCommand(custInfo, connect);
                    MySqlDataReader creader = ccmd.ExecuteReader();
                    customerFill.Load(creader);

                    nameTxt.Text = (string)customerFill.Rows[UniversalCode.CurrentCustIndex]["customerName"];
                    addressTxt.Text = (string)customerFill.Rows[UniversalCode.CurrentCustIndex]["address"];
                    zipTxt.Text = (string)customerFill.Rows[UniversalCode.CurrentCustIndex]["postalCode"];
                    phoneTxt.Text = (string)customerFill.Rows[UniversalCode.CurrentCustIndex]["phone"];
                    cityCB.Text = (string)customerFill.Rows[UniversalCode.CurrentCustIndex]["city"];
                    connect.Close();
                }
            }
        }
        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dash = new UserDashboard();
            dash.Show();
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {

            if (UniversalCode.CustomerID > 0)
            {
                UpdateCustomerData();
            }
            else
            {
                InsertCustomerData();
            }

        }
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            bool validName = UniversalCode.IsNotNullOrEmpty(nameTxt.Text);
            UniversalCode.ValidateField(nameTxt, validName);
            saveCustomerBtn.Enabled = SaveAllowed();
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            bool validAddress = UniversalCode.IsNotNullOrEmpty(addressTxt.Text);
            UniversalCode.ValidateField(addressTxt, validAddress);
            saveCustomerBtn.Enabled = SaveAllowed();
        }

        private void zipTxt_TextChanged(object sender, EventArgs e)
        {
            bool zipFormat = UniversalCode.CheckZipFormat(zipTxt.Text.ToString());
            bool validZip = UniversalCode.IsNotNullOrEmpty(zipTxt.Text);
            UniversalCode.ValidateField(zipTxt, validZip);
            UniversalCode.ValidateField(zipTxt, zipFormat);
            saveCustomerBtn.Enabled = SaveAllowed();
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            bool format = UniversalCode.CheckPhoneFormat(phoneTxt.Text.ToString());
            bool validPhone = UniversalCode.IsNotNullOrEmpty(phoneTxt.Text);
            UniversalCode.ValidateField(phoneTxt, validPhone);
            UniversalCode.ValidateField(phoneTxt, format);

            if (phoneTxt.BackColor.Equals(Color.LightGray)) // shades out text box if incorrect format entered
            {
                errorLbl.Text = "Please enter as ###-####";
                saveCustomerBtn.Enabled = false;
            }
            else if (phoneTxt.BackColor.Equals(Color.White))
            {
                errorLbl.Text = "";
                saveCustomerBtn.Enabled = true; // enables save button when correct format is entered
            }
        }

        private void AddUpdateCustomerForm_Load(object sender, EventArgs e)
        {
            saveCustomerBtn.Enabled = SaveAllowed();
        }

        public void InsertCustomerData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    con.Open();

                   
                    string getCity = cityCB.GetItemText(cityCB.Text);

                 
                    string sql = "SELECT cityId from city where city = '" + getCity + "';";

                    MySqlCommand city = new MySqlCommand(sql, con);
                    MySqlDataAdapter cityAdapter = new MySqlDataAdapter(city);
                    DataTable cityResult = new DataTable();
                    cityAdapter.Fill(cityResult);
                    if (cityResult.Rows.Count > 0)
                    {
                        int cID = Convert.ToInt32(cityResult.Rows[0][0]);
                        UniversalCode.CityID = cID;
                    }
                    //Sql query to insert address data into table 
                    string insertAddressData =
                        "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + addressTxt.Text + "', ' ', '" + UniversalCode.CityID + "', '" + zipTxt.Text + "', '" + phoneTxt.Text + "', '"
                         + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm") + "', '" + UniversalCode.CurrentUser + "', '" + UniversalCode.CurrentUser + "');";

                    //Sql query to selectaddress ID from address table
                    string getAddress = "SELECT addressId FROM address WHERE address = '" + addressTxt.Text + "';";

                    MySqlCommand addressInsert = new MySqlCommand(insertAddressData, con);
                    addressInsert.ExecuteNonQuery();
                    MySqlCommand address = new MySqlCommand(getAddress, con);
                    MySqlDataAdapter addressAdapter = new MySqlDataAdapter(address);
                    DataTable addressResult = new DataTable();
                    addressAdapter.Fill(addressResult);

                    if (addressResult.Rows.Count > 0)
                    {
                        int aID = Convert.ToInt32(addressResult.Rows[0][0]);
                        UniversalCode.AddressID = aID;
                    }

                    //query to insert customer data into customer table
                    string insertCustomerData =
                        "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + nameTxt.Text + "', '" + UniversalCode.AddressID + "', 1 ,'" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm") + "', '" + UniversalCode.CurrentUser + "', '" + UniversalCode.CurrentUser + "');";

                    MySqlCommand insertCustomer = new MySqlCommand(insertCustomerData, con);
                    insertCustomer.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                    UserDashboard dash = new UserDashboard();
                    dash.Show();

                    MessageBox.Show("Customer created.");
                    Close();
                }
            }
            catch (Exception)
            {
                errorLbl.Text = "An error has occurred. Please try again.";
            }
        }

        public void UpdateCustomerData()
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(DatabaseSQL.ConnectionString))
                {
                    connect.Open();
                    
                    string updateCity = cityCB.GetItemText(cityCB.SelectedItem);
                    string citySql = "SELECT cityId FROM city WHERE city ='" + updateCity + "';";

                    MySqlCommand getCity = new MySqlCommand(citySql, connect);
                    MySqlDataAdapter city = new MySqlDataAdapter(getCity);
                    DataTable cityCombo = new DataTable();
                    city.Fill(cityCombo);
                    if (cityCombo.Rows.Count > 0)
                    {
                        int id = (int)cityCombo.Rows[0][0];
                        UniversalCode.CityID = id;
                    }

                    string addressID = "SELECT addressId FROM customer WHERE customerId = '" + UniversalCode.CustomerID + "';";

                    MySqlCommand getAddress = new MySqlCommand(addressID, connect);
                    MySqlDataAdapter address = new MySqlDataAdapter(getAddress);
                    DataTable addressDt = new DataTable();
                    address.Fill(addressDt);
                    if (addressDt.Rows.Count > 0)
                    {
                        int addressid = (int)addressDt.Rows[0][0];
                        UniversalCode.AddressID = addressid;
                    }
                    string addressUpdate =
                        "UPDATE address SET address = '" + addressTxt.Text + "', postalCode ='" + zipTxt.Text + "', phone ='" + phoneTxt.Text + "', cityId ='" + UniversalCode.CityID + "', " +
                        "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm") + "',  " +
                        "lastUpdateBy = '" + UniversalCode.CurrentUser + "' " +
                        "WHERE addressId = '" + UniversalCode.AddressID + "';";

                    string customerUpdate = "UPDATE customer SET customerName = '" + nameTxt.Text + "', " + "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm") + "',  " +
                        "lastUpdateBy = '" + UniversalCode.CurrentUser + "' " +
                        "WHERE customerId = '" + UniversalCode.CustomerID + "';";

                    MySqlCommand updateAddress = new MySqlCommand(addressUpdate, connect);
                    updateAddress.ExecuteNonQuery();

                    MySqlCommand updateCustomer = new MySqlCommand(customerUpdate, connect);
                    updateCustomer.ExecuteNonQuery();
                    connect.Close();

                    this.Hide();
                    UserDashboard dash = new UserDashboard();
                    dash.Show();

                    MessageBox.Show("Customer Updated.");
                    Close();
                }
            }
            catch (Exception)
            {
                errorLbl.Text = "An error has occurred. Please try again.";
            }
        }

        private void cityCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
