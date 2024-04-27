using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class registration_form : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public registration_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // button for selecting image to be uploaded to the picturebox.
        private void profile_upload_btn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    profile_pic_pbx.ImageLocation = imageLocation;
                }
            }
                catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // this button will insert all data inputs to the database.
        private void update_info_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `accounts`(`accID`, `Profile_pic`, `first_name`, `last_name`, `name`, `Birthdate`, `age`, `sex`, `password`, `Address`, `Telephone_no`, `Voter_status`, `Marital_status`, `No_of_fam_mem`, `Mon_income`, `educational_attainment`, `occupation`, `vaccination_status`) " +
                "VALUES (NULL, @Profile_pic, @first_name, @last_name, @name, @Birthdate, @age, @sex, @password, @Address, @Telephone_no, @Voter_status, @Marital_status, @No_of_fam_mem, @Mon_income, @educational_attainment, @occupation, @vaccination_status)", con);


                MemoryStream ms = new MemoryStream();
                profile_pic_pbx.Image.Save(ms, profile_pic_pbx.Image.RawFormat);
                byte[] pImg = ms.ToArray();
                string name = fname_tbx.Text + " " + Lname_tbx.Text;
                string pass = pass_tbx.Text;
                string phone_num = phone_num_tbx.Text;
                string fname = fname_tbx.Text;
                string lname = Lname_tbx.Text;
                string bdate = birthdate_dtp.Value.ToString("yyyy-MM-dd");
                int age = (int)age_npicker.Value;
                string sex = acc_sex.Text;
                string Vstatus = voter_status.Text;
                string vaccstatus = vacc_status.Text;
                string address = Address_tbx.Text;
                string Mstatus = Marital_status.Text;
                int nooffammem = (int)num_fam.Value;
                string mon_income = monthly_income.Text;
                string educ_attainment = educ_attain.Text;
                string occupation = occupation_cmbx.Text;

                string hashedpass = Hashhelper.Hashstring(pass);

                if (pImg == null || name == null || pass == null || phone_num == null || fname == null || lname == null || bdate == null || age == 0 || sex == null || Vstatus == null || vaccstatus == null || address == null || Mstatus == null || nooffammem == 0 || mon_income == null || educ_attainment == null || occupation == null)
                {
                    MessageBox.Show("Please fill up all empty fields");
                }
                else
                {
                    if (pass_tbx.Text == conp_tbx.Text)
                    {
                        cmd.Parameters.AddWithValue("@Profile_pic", pImg);
                        cmd.Parameters.AddWithValue("@first_name", fname);
                        cmd.Parameters.AddWithValue("@last_name", lname);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@Birthdate", bdate);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@password", hashedpass);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Telephone_no", phone_num);
                        cmd.Parameters.AddWithValue("@Voter_status", Vstatus);
                        cmd.Parameters.AddWithValue("@Marital_status", Mstatus);
                        cmd.Parameters.AddWithValue("@No_of_fam_mem", nooffammem);
                        cmd.Parameters.AddWithValue("@Mon_income", mon_income);
                        cmd.Parameters.AddWithValue("@educational_attainment", educ_attainment);
                        cmd.Parameters.AddWithValue("@occupation", occupation);
                        cmd.Parameters.AddWithValue("@vaccination_status", vaccstatus);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Welcome " + name + ". You have been successfully registered.");

                            Image default_pic = Properties.Resources.profile_dflt;
                            profile_pic_pbx.Image = default_pic;
                            acc_name_tbx.Clear();
                            pass_tbx.Clear();
                            conp_tbx.Clear();
                            phone_num_tbx.Clear();
                            fname_tbx.Clear();
                            Lname_tbx.Clear();
                            birthdate_dtp.Value = DateTimePicker.MinimumDateTime;
                            age_npicker.Value = 0;
                            acc_sex.Text = null;
                            voter_status.Text = null;
                            vacc_status.Text = null;
                            Address_tbx.Clear();
                            Marital_status.Text = null;
                            num_fam.Value = 0;
                            monthly_income.Clear();
                            educ_attain.Text = null;
                            occupation_cmbx.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password does not match the password. Please try again.");
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
        // this is a method that automatically sets the age's value based on the value of the birthdate.
        private void age_npicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime Selecteddate = birthdate_dtp.Value;
            int age = age_autofiller.CalculateAge(Selecteddate);

            age_npicker.Value = age;
        }
        // this is a button for uncensoring password.
        private void show_btn2_Click(object sender, EventArgs e)
        {
            if (pass_tbx.PasswordChar == '*')
            {
                hide_btn2.BringToFront();
                pass_tbx.PasswordChar = '\0';
            }
        }
        // this is a button for censoring password.
        private void hide_btn2_Click(object sender, EventArgs e)
        {
            if (pass_tbx.PasswordChar == '\0')
            {
                show_btn2.BringToFront();
                pass_tbx.PasswordChar = '*';
            }
        }
        // this is a button for uncensoring confirm password.
        private void con_show_btn_Click(object sender, EventArgs e)
        {
            if (conp_tbx.PasswordChar == '*')
            {
                con_hide_btn.BringToFront();
                conp_tbx.PasswordChar = '\0';
            }
        }
        // this is a button for censoring confirm password.
        private void con_hide_btn_Click(object sender, EventArgs e)
        {
            if (conp_tbx.PasswordChar == '\0')
            {
                con_show_btn.BringToFront();
                conp_tbx.PasswordChar = '*';
            }
        }
    }
}
