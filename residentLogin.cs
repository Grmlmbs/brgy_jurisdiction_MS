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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    // this is a log in form for the resident that is connected to the database.
    public partial class login : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public login()
        {
            InitializeComponent();
        }
      
        private void Name_tbx_TextChanged(object sender, EventArgs e)
        {
            this.ActiveControl = Name_tbx;
            Name_tbx.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // this is the log in button that is connected to the database and has code blocks to handled account logins.
        private void signin_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(database);

            try
            {
                string name = Name_tbx.Text;
                string password = Password_tbx.Text;

                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                string hashedPassword = Hashhelper.Hashstring(password);

                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT password FROM accounts WHERE name = @name", conn);
                query.Parameters.AddWithValue("@name", name);
                string dbHashedPassword = query.ExecuteScalar() as string;

                if (dbHashedPassword != null && hashedPassword == dbHashedPassword)
                {
                    MessageBox.Show("Welcome " + name);
                    Accountdetails user = retrievedata(name, hashedPassword);
                    residentDashboard resdntDashboard = new residentDashboard(user);
                    resdntDashboard.Show();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private void show_btn_Click(object sender, EventArgs e)
        {
            if(Password_tbx.PasswordChar == '*')
            {
                hide_btn.BringToFront();
                Password_tbx.PasswordChar = '\0';
            }
        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            if (Password_tbx.PasswordChar == '\0')
            {
                show_btn.BringToFront();
                Password_tbx.PasswordChar = '*';
            }
        }
        private void login_Load(object sender, EventArgs e)
        {
        }

        private void animationtimer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1.0)
            {
                opacitytimer.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        // this method will retrieve all the data connected to the "name" and "password" then set the values that is read to the classess that we made.
        private Accountdetails retrievedata(string name, string password)
        {
            Accountdetails user = null;
            try
            {
                MySqlConnection con = new MySqlConnection(database);

                con.Open();
                string query = "SELECT * FROM accounts WHERE name = @name" /*AND password = @password*/;
                MySqlCommand com = new MySqlCommand(query, con);

                com.Parameters.AddWithValue("@name", name);
                //com.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = com.ExecuteReader();

                if(reader.Read())
                {
                    user = new Accountdetails
                    {
                        _acc_ID = reader.GetInt32("accID"),
                        _profile_pic = reader["Profile_pic"] == DBNull.Value ? null : (byte[])reader["Profile_pic"],
                        _fname = reader.GetString("first_name"),
                        _Lname = reader.GetString("last_name"),
                        _acc_name = reader.GetString("name"),
                        _birthdate = reader.GetDateTime("Birthdate"),
                        _age = reader.GetInt32("age"),
                        _sex = reader.GetString("sex"),
                        _acc_pass = Password_tbx.Text,
                        _address = reader.GetString("Address"),
                        _phone_no = reader.GetInt32("Telephone_no"),
                        _voter_status = reader.GetString("Voter_status"),
                        _marital_status = reader.GetString("Marital_status"),
                        _no_of_fam = reader.GetInt32("No_of_fam_mem"),
                        _mon_income = reader.GetInt32("Mon_income"),
                        _educ_attain = reader.GetString("educational_attainment"),
                        _occupation = reader.GetString("occupation"),
                        _vacc_status = reader.GetString("vaccination_status"),
                    };
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving user information " + ex.Message + "Error");
            }
            return user;
        }

        private void signin_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin_btn.PerformClick();
            }
        }
    }
}
