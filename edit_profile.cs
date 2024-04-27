using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class edit_profile : Form
    {
        public Dictionary<string, object> SelectedRowData { get; set; }
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public edit_profile()
        {
            InitializeComponent();
        }
        // this is a button for uncensoring password
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

        // this is a code block for uploading image to the picture box.
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
        // this will populate the form with the preexsisting data that the user previously inputed in the account.
        private void edit_profile_Load(object sender, EventArgs e)
        {
            if (SelectedRowData != null)
            {
                if (SelectedRowData.ContainsKey("Profile_picture") && SelectedRowData["Profile_picture"] is Image)
                {
                    Image profilePicture = (Image)SelectedRowData["Profile_picture"];

                    profile_pic_pbx.Image = profilePicture;
                }
                else
                {
                    profile_pic_pbx.Image = Properties.Resources.profile_dflt2;
                }
            }
            conp_tbx.Text = SelectedRowData["res_acc_password"].ToString();
            pass_tbx.Text = SelectedRowData["res_acc_password"].ToString();
            acc_name_tbx.Text = SelectedRowData["res_name"].ToString();
            fname_tbx.Text = SelectedRowData["First_name"].ToString();
            Lname_tbx.Text = SelectedRowData["Last_name"].ToString();

            if (SelectedRowData.ContainsKey("res_acc_birthdate"))
            {
                string birthdateValue = SelectedRowData["res_acc_birthdate"].ToString();

                DateTime birthdate = DateTime.Parse(birthdateValue);

                birthdate_dtp.Value = birthdate;
            }

            phone_num_tbx.Text = SelectedRowData["Tel_no"].ToString();
            age_npicker.Value = Convert.ToInt32(SelectedRowData["res_acc_age"]);
            acc_sex.Text = SelectedRowData["res_acc_sex"].ToString();
            voter_status.Text = SelectedRowData["Voter_status"].ToString();
            vacc_status.Text = SelectedRowData["vacc_status"].ToString();
            Address_tbx.Text = SelectedRowData["res_acc_address"].ToString();
            Marital_status.Text = SelectedRowData["marital_status"].ToString();
            num_fam.Value = Convert.ToInt32(SelectedRowData["no_of_fam_mem"]);
            monthly_income.Text = SelectedRowData["mon_income"].ToString();
            educ_attain.Text = SelectedRowData["educ_attainment"].ToString();
            occupation_cmbx.Text = SelectedRowData["res_acc_occupation"].ToString();
        }

        // this is a code block for the update button.
        private void update_info_btn_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(database);
            try
            {
                string query = "UPDATE `accounts` SET Profile_pic = @first_name = @first_name, last_name = @last_name, name = @name," +
                    " Birthdate = @birthdate, age = @age, sex = @sex, password = @password, Address = @address, Telephone_no = @Telephone_no, Voter_status = @Voter_status," +
                    " Marital_status = @Marital_status, No_of_fam_mem = @No_of_fam_mem, Mon_income = @mon_income, educational_attainment = @educ_attainment, occupation = @occupation," +
                    " vaccination_status = @vacc_status WHERE accID = @Resident_ID";

                MySqlCommand com = new MySqlCommand(query, con);

                byte[] profilePictureBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    profile_pic_pbx.Image.Save(ms, profile_pic_pbx.Image.RawFormat);
                    profilePictureBytes = ms.ToArray();
                }
                int res_ID = Convert.ToInt32(SelectedRowData["Resident_ID"]);
                string pass = pass_tbx.Text;
                string conpass = conp_tbx.Text;
                string address = Address_tbx.Text;
                string phone_num = phone_num_tbx.Text;
                string Vstatus = voter_status.Text;
                string Mstatus = Marital_status.Text;
                int nooffammem = (int)num_fam.Value;
                string mon_income = monthly_income.Text;
                string educ_attainment = educ_attain.Text;
                string occupation = occupation_cmbx.Text;
                string vaccstatus = vacc_status.Text;

                string hashedpass = Hashhelper.Hashstring(pass);

                con.Open();

                com.Parameters.AddWithValue("@profile_pic", profilePictureBytes);
                com.Parameters.AddWithValue("@Resident_ID", res_ID);
                com.Parameters.AddWithValue("@first_name", fname_tbx.Text);
                com.Parameters.AddWithValue("@last_name", Lname_tbx.Text);
                com.Parameters.AddWithValue("@name", acc_name_tbx.Text);
                com.Parameters.AddWithValue("@birthdate", birthdate_dtp.Value.ToString("yyyy-MM-dd"));
                com.Parameters.AddWithValue("@age", (int)age_npicker.Value);
                com.Parameters.AddWithValue("@sex", acc_sex.Text);


                string anotherquery = "SELECT `password` FROM `accounts` WHERE accID = @Resident_ID";
                MySqlCommand retricommand = new MySqlCommand(anotherquery, con);
                retricommand.Parameters.AddWithValue("@Resident_ID", res_ID);
                MySqlDataReader reader = retricommand.ExecuteReader();
                if (reader.Read())
                {
                    string passfromdatabase = reader.GetString("password");
                    if (passfromdatabase != pass)
                    {
                        if (pass != conpass)
                        {
                            MessageBox.Show("Password and confirm password do not match.");
                            return;
                        }
                        else
                        {
                            com.Parameters.AddWithValue("@password", hashedpass);
                        }
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@password", pass);
                    }
                }
                reader.Close();

                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@Telephone_no", phone_num);
                com.Parameters.AddWithValue("@Voter_status", Vstatus);
                com.Parameters.AddWithValue("@Marital_status", Mstatus);
                com.Parameters.AddWithValue("@No_of_fam_mem", nooffammem);
                com.Parameters.AddWithValue("@mon_income", mon_income);
                com.Parameters.AddWithValue("@educ_attainment", educ_attainment);
                com.Parameters.AddWithValue("@occupation", occupation);
                com.Parameters.AddWithValue("@vacc_status", vaccstatus);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data successfully updated");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error:" + er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // close the form.
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
