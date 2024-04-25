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
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    // this is sign up form for the barangay employees.
    public partial class Form2 : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public Form2()
        {
            InitializeComponent();
        }

        // this is an exit button for the sign up form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            signupoptions open = new signupoptions();
            open.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // this is the code block for a sign up button that is connected to the database.
        private void signin_btn_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(database);

            string name = empfirstname_tbx.Text.ToString() + " " + emplastname_tbx.Text.ToString();
            string lastname = emplastname_tbx.Text.ToString();
            string firstname = empfirstname_tbx.Text.ToString();
            string birthdate1 = empbirthdate.Text.ToString();
            decimal ageselector = empage.Value;
            string sex1 = empsex.Text;
            string password = empPassword_tbx.Text.ToString();
            string conpass = empConfirmpass_tbx.Text.ToString();
            string empID = empID_tbx.Text.ToString();

            string hashedpass = Hashhelper.Hashstring(password);

            string query = $"INSERT INTO `employee_database`(`primary_key`, `Employee_name`, `Birthdate`, `Age`, `Sex`, `Employee_pass`, `Employee_ID`)  VALUES ('NULL','{name}','{birthdate1}','{ageselector}','{sex1}','{hashedpass}','{empID}')";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                if (String.IsNullOrEmpty(name) || birthdate1 == null || ageselector == null || String.IsNullOrEmpty(sex1) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(conpass) || String.IsNullOrEmpty(empID))
                {
                    MessageBox.Show("Please fill up all empty fields");
                }
                else
                {
                    if(password == conpass)
                    {
                        cmd.Parameters.AddWithValue("first_name", firstname);
                        cmd.Parameters.AddWithValue("last_name", lastname);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("Birthdate", birthdate1);
                        cmd.Parameters.AddWithValue("age", ageselector);
                        cmd.Parameters.AddWithValue("sex", sex1);
                        cmd.Parameters.AddWithValue("password", hashedpass);
                        cmd.Parameters.AddWithValue("Emploteep_ID", empID);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Welcome " + name + ". Please proceed to log in your account.");
                            empfirstname_tbx.Clear();
                            emplastname_tbx.Clear();
                            empage.Value = 0;
                            empbirthdate.Value = DateTimePicker.MinimumDateTime;
                            empsex.Items.Clear();
                            empPassword_tbx.Clear();
                            empConfirmpass_tbx.Clear();
                            empID_tbx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected");
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The password doesn't match to the confirmed password. Please try again.");
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

        // this is a button that would clear every inputed fields incase the employee wants to cancel his/her registration.
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            empfirstname_tbx.Clear();
            emplastname_tbx.Clear();
            empage.Value = 0;
            empbirthdate.Value = DateTimePicker.MinimumDateTime;
            empsex.Items.Clear();
            empPassword_tbx.Clear();
            empConfirmpass_tbx.Clear();
            empID_tbx.Clear();
        }

        private void show_btn1_Click(object sender, EventArgs e)
        {
            if (empPassword_tbx.PasswordChar == '*')
            {
                hide_btn1.BringToFront();
                empPassword_tbx.PasswordChar = '\0';
            }
        }

        private void hide_btn1_Click(object sender, EventArgs e)
        {
            if (empPassword_tbx.PasswordChar == '\0')
            {
                show_btn1.BringToFront();
                empPassword_tbx.PasswordChar = '*';
            }
        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            if (empConfirmpass_tbx.PasswordChar == '*')
            {
                hide_btn2.BringToFront();
                empConfirmpass_tbx.PasswordChar = '\0';
            }
        }

        private void hide_btn2_Click(object sender, EventArgs e)
        {
            if (empConfirmpass_tbx.PasswordChar == '\0')
            {
                show_btn2.BringToFront();
                empConfirmpass_tbx.PasswordChar = '*';
            }
        }

        private void animations_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1.0)
            {
                animations.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        private void empage_ValueChanged(object sender, EventArgs e)
        {
            DateTime Selecteddate = empbirthdate.Value;
            int age = age_autofiller.CalculateAge(Selecteddate);

            empage.Value = age;
        }

        private void signin_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signup_btn.PerformClick();
            }
        }
    }
}
