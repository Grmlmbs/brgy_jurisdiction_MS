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
    public partial class signup : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public signup()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            firstname_tbx.Clear();
            lastname_tbx.Clear();
            age.Value = 0;
            birthdate.Value = DateTimePicker.MinimumDateTime;
            sex.Items.Clear();
            Password_tbx.Clear();
            Confirmpass_tbx.Clear();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);

            string name = firstname_tbx.Text.ToString() + " " + lastname_tbx.Text.ToString();
            string lastname = lastname_tbx.Text.ToString();
            string firstname = firstname_tbx.Text.ToString();
            string birthdate1 = birthdate.Text.ToString();
            decimal ageselector = age.Value;
            string sex1 = sex.Text;
            string password = Password_tbx.Text.ToString();
            string conpass = Confirmpass_tbx.Text.ToString();

            string query = $"INSERT INTO `accounts`(`accID`, `first_name`, `last_name`, `name`, `Birthdate`, `age`, `sex`, `password`) VALUES ('NULL','{firstname}','{lastname}','{name}','{birthdate1}','{ageselector}','{sex1}','{password}')";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                if(String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(lastname) || birthdate1 == null || ageselector == null || String.IsNullOrEmpty(sex1) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(conpass))
                {
                    MessageBox.Show("Please fill up all empty fields");
                }
                else
                {
                    if (Password_tbx.Text == Confirmpass_tbx.Text)
                    {
                        cmd.Parameters.AddWithValue("first_name", firstname);
                        cmd.Parameters.AddWithValue("last_name", lastname);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("Birthdate", birthdate1);
                        cmd.Parameters.AddWithValue("age", ageselector);
                        cmd.Parameters.AddWithValue("sex", sex1);
                        cmd.Parameters.AddWithValue("password", password);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Welcome " + name + ". Please proceed to log in your account.");
                            firstname_tbx.Clear();
                            lastname_tbx.Clear();
                            age.Value = 0;
                            birthdate.Value = DateTimePicker.MinimumDateTime;
                            sex.Items.Clear();
                            Password_tbx.Clear();
                            Confirmpass_tbx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected");
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The password does not match the password. Please try again.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            signupoptions open = new signupoptions();
            open.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Password_tbx.PasswordChar == '*')
            {
                hide_btn1.BringToFront();
                Password_tbx.PasswordChar = '\0';
            }
        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            if (Confirmpass_tbx.PasswordChar == '*')
            {
                hide_btn2.BringToFront();
                Confirmpass_tbx.PasswordChar = '\0';
            }
        }

        private void hide_btn1_Click(object sender, EventArgs e)
        {
            if (Password_tbx.PasswordChar == '\0')
            {
                show_btn1.BringToFront();
                Password_tbx.PasswordChar = '*';
            }
        }

        private void hide_btn2_Click(object sender, EventArgs e)
        {
            if (Confirmpass_tbx.PasswordChar == '\0')
            {
                show_btn2.BringToFront();
                Confirmpass_tbx.PasswordChar = '*';
            }
        }

        private void firstname_tbx_TextChanged(object sender, EventArgs e)
        {

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

        private void lastname_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmpass_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
