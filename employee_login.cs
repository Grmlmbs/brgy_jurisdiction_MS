using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    // This is a log in form for the employee.
    public partial class employee_login : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public employee_login()
        {
            InitializeComponent();
        }

        //Log in an employee account.

        private void signin_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);

            try
            {
                string empname = empName_tbx.Text.ToString();
                string emppass = empPassword_tbx.Text.ToString();
                string empID = empID_tbx.Text.ToString();

                string hashedemppass = Hashhelper.Hashstring(emppass);

                if(String.IsNullOrEmpty(empname) || String.IsNullOrEmpty(emppass) || String.IsNullOrEmpty(empID))
                {
                    MessageBox.Show("Please fill up empty fields");
                }
                else 
                {
                    con.Open();
                    MySqlCommand query = new MySqlCommand("SELECT Employee_pass FROM employee_database WHERE Employee_name = @name AND Employee_ID = @Employee_ID", con);
                    query.Parameters.AddWithValue("@name", empname);
                    query.Parameters.AddWithValue("@Employee_ID", empID);
                    string dbhashedemppass = query.ExecuteScalar() as string;

                    int foundaccount = 0;
                    if(dbhashedemppass != null && hashedemppass == dbhashedemppass)
                    {
                            
                        MessageBox.Show("Welcome " + empname);
                        employee_acc_details emp_acc_details;
                        empDashboard admindashboard = new empDashboard();
                        admindashboard.Show();
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Hide();
                        foundaccount++;
                    }
                    if(foundaccount == 0)
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
                con.Close();
            }
        }
        // this method will retrieve the data in the database that is then gonna be used later to be viewed in the account details for the employee.
        public employee_acc_details retrieve_emp_data(string name, string password)
        {
            employee_acc_details employee = null;
            try
            {
                MySqlConnection con = new MySqlConnection(database);

                con.Open();
                string query = "SELECT * FROM employee_database WHERE Employee_name = @Employee_name AND Employee_pass = @Employee_pass";
                MySqlCommand com = new MySqlCommand(query, con);

                com.Parameters.AddWithValue("@Employee_name", name);
                com.Parameters.AddWithValue("@Employee_pass", password);
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    employee = new employee_acc_details
                    {
                        primary_key = reader.GetInt32("primay_ID"),
                        emp_name = reader.GetString("Employee_name"),
                        emp_pass = reader.GetString("Employee_pass"),
                        emp_birthdate = reader.GetDateTime("Birthdate"),
                        emp_age = reader.GetInt32("Age"),
                        emp_sex = reader.GetString("sex"),
                        emp_ID = reader.GetInt32("Employee_ID"),
                    };
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving employee information " + ex.Message + "Error");
            }
            return employee;
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(empPassword_tbx.PasswordChar == '*')
            {
                hide_btn.BringToFront();
                empPassword_tbx.PasswordChar = '\0';
            }
        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            if (empPassword_tbx.PasswordChar == '\0')
            {
                show_btn.BringToFront();
                empPassword_tbx.PasswordChar = '*';
            }
        }

        private void animation_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1.0)
            {
                animation.Stop();
            }
            else
            {
                Opacity += .03;
            }
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
