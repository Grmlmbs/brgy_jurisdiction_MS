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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{

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

        public static void new_message(int and, string name_mess, string pass_mess)
        {
            string gen_mess = "Please enter";
            string addand = " and ";
            switch(and)
            {
                case 1:
                    MessageBox.Show(gen_mess + name_mess + pass_mess + ".");
                    break;
                case 2:
                    MessageBox.Show(gen_mess + name_mess + addand + pass_mess + ".");
                    break;
            }
        }
        private void signin_btn_Click(object sender, EventArgs e)
        {
            Accountdetails user = retrievedata(Name_tbx.Text, Password_tbx.Text);
            MySqlConnection conn = new MySqlConnection(database);

            try
            {
                int and = 0;
                string name_mess = "";
                string pass_mess = "";
                string name = Name_tbx.Text.ToString();
                string password = Password_tbx.Text.ToString();

                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password))
                {
                    if (String.IsNullOrEmpty(name))
                    {
                        name_mess = " name";
                        Name_tbx.BackColor = Color.Red;
                        and++;
                    }
                    if (String.IsNullOrEmpty(password))
                    {
                        pass_mess = " password";
                        Password_tbx.BackColor = Color.Red;
                        and++;
                    }
                    new_message(and, name_mess, pass_mess);
                }
                else
                {
                    conn.Open();
                    MySqlCommand query= new MySqlCommand("SELECT * FROM accounts", conn);
                    MySqlDataReader reader = query.ExecuteReader();

                    int foundaccount = 0;
                    while(reader.Read())
                    {
                        if (name.Equals(reader.GetString("name")) && password.Equals(reader.GetString("password")))
                        {
                            MessageBox.Show("Welcome " + name);
                            residentDashboard resdntDashboard = new residentDashboard(user);
                            resdntDashboard.Show();
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Hide();
                            foundaccount++;
                        }
                    }
                    if (foundaccount == 0)
                    {
                        MessageBox.Show("Sorry but your account you had logged in does not exist!. Pleare try again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error");
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
        private Accountdetails retrievedata(string name, string password)
        {
            Accountdetails user = null;
            try
            {
                MySqlConnection con = new MySqlConnection(database);

                con.Open();
                string query = "SELECT * FROM accounts WHERE name = @name and password = @password";
                MySqlCommand com = new MySqlCommand(query, con);

                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = com.ExecuteReader();

                if(reader.Read())
                {
                    user = new Accountdetails
                    {
                        _acc_ID = reader.GetInt32("accID"),
                        _profile_pic = (byte[])reader["Profile_pic"],
                        _fname = reader.GetString("first_name"),
                        _Lname = reader.GetString("last_name"),
                        _acc_name = reader.GetString("name"),
                        _birthdate = reader.GetDateTime("Birthdate"),
                        _age = reader.GetInt32("age"),
                        _sex = reader.GetString("sex"),
                        _acc_pass = reader.GetString("password"),
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
                MessageBox.Show("Error retrievign user information" + ex.Message + "Error");
            }
            return user;
        }
    }
}
