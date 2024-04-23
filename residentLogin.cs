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
                            residentDashboard resdntDashboard = new residentDashboard();
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
    }
}
