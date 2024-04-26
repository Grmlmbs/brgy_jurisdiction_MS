using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Encoders;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using WindowsFormsApp1.employee_tabs_controls;

namespace WindowsFormsApp1
{
    public partial class Abt_account : UserControl
    {
        static string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public Abt_account()
        {
            InitializeComponent();
        }
        //this method will take the retrieved data to it's designated controls.
        public static void enteruserdetails(string resident_id)
        {
            MySqlConnection con = new MySqlConnection(database);

            string query = "SELECT * FROM accounts WHERE accID = @accID";
            MySqlCommand com = new MySqlCommand(query, con);

            com.Parameters.AddWithValue("@accID", resident_id);
            try
            {
                con.Open();
                MySqlDataReader reader = com.ExecuteReader();

                int rowIndex = 0;
                while (reader.Read())
                {
                    byte[] profile_pic = (byte[])reader["Profile_pic"];
                    string firstname = reader.GetString("first_name");
                    string lastname = reader.GetString("last_name");
                    string fullname = reader.GetString("name");
                    string password = reader.GetString("password");
                    string birthdate = reader.GetDateTime("Birthdate").ToString("yyyy-MM-dd");
                    int age = reader.GetInt32("age");
                    string sex = reader.GetString("sex");
                    string address = reader.GetString("Address");
                    int pnoneNumber = reader.GetInt32("Telephone_no");
                    string voterStatus = reader.GetString("Voter_status");
                    string MaritalStatus = reader.GetString("Marital_status");
                    int NoOfFamMem = reader.GetInt32("No_of_fam_mem");
                    int MonIncome = reader.GetInt32("Mon_income");
                    string educAttainment = reader.GetString("educational_attainment");
                    string occupation = reader.GetString("occupation");
                    string vaccStatus = reader.GetString("vaccination_status");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Unable to retrieve data" + er.Message + "Error");
            }
            finally
            {
                con.Close();
            }
        }
        
        private void Abt_account_Load(object sender, EventArgs e)
        {
            //enteruserdetails(summaries_uc.);
        }

        // button for selecting image tto be uploaded to the picturebox.
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

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
