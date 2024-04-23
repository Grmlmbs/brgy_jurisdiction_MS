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

namespace WindowsFormsApp1
{
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

                if(String.IsNullOrEmpty(empname) || String.IsNullOrEmpty(emppass) || String.IsNullOrEmpty(empID))
                {
                    MessageBox.Show("Please fill up empty fields");
                }
                else 
                {
                    con.Open();
                    MySqlCommand query = new MySqlCommand("SELECT * FROM employee_database", con);
                    MySqlDataReader reader = query.ExecuteReader();


                    int foundaccount = 0;
                    while (reader.Read())
                    {
                        if(empname.Equals(reader.GetString("Employee_name")) && emppass.Equals(reader.GetString("Employee_pass")) && empID.Equals(reader.GetString("Employee_ID")))
                        {
                            
                            MessageBox.Show("Welcome " + empname);
                            empDashboard admindashboard = new empDashboard();
                            admindashboard.Show();
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Hide();
                            foundaccount++;
                        }
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
    }
}
