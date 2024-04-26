using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.employee_tabs_controls;
using WindowsFormsApp1.userControlMkAn;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class empDashboard : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public empDashboard()
        {
            InitializeComponent();

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private List<ResidentData> GetResidentsFromDatabase()
        {
            List<ResidentData> residents = new List<ResidentData>();

            string connectionString = "server = localhost; user = root; database = resident_database; sslMode = none;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT `post_id`, `post_img`, `post_what`, `post_who`, `post_when`, `post_where`, `post_why`, `post_how` FROM `posted_events`";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResidentData resident = new ResidentData
                            {
                                ID = reader.GetInt32("post_id"),
                                Image = (byte[])reader["post_img"],
                                What = reader.GetString("post_what"),
                                Who = reader.GetString("post_who"),
                                When = reader.GetDateTime("post_when"),
                                Where = reader.GetString("post_where"),
                                Why = reader.GetString("post_why"),
                                How = reader.GetString("post_how"),
                            };
                            residents.Add(resident);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return residents;
        }

        // this method will help populate the flowpanel with the post
        private void PopulateCustomListWithResidents()
        {
            try
            {
                List<ResidentData> residents = GetResidentsFromDatabase();

                flowLayoutPanel1.Controls.Clear();

                foreach (ResidentData resident in residents)
                {
                    post_uc postUC = new post_uc();

                    using (MemoryStream ms = new MemoryStream(resident.Image))
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        postUC.events_image_pbx.Image = Image.FromStream(ms);
                    }
                    postUC.what_con_tbx.Text = resident.What;
                    postUC.who_con_tbx.Text = resident.Who;
                    postUC.when_con_tbx.Text = resident.When.ToString();
                    postUC.where_con_tbx.Text = resident.Where;
                    postUC.why_con_tbx.Text = resident.Why;
                    postUC.how_con_tbx.Text = resident.How;


                    flowLayoutPanel1.Controls.Add(postUC);
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er + "Error");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PopulateCustomListWithResidents();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void accName_btn_Click(object sender, EventArgs e)
        {
            accounttabexpand.Start();
            accPanel.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void blotters_btn_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = true;
        private void accounttabexpand_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                container.Height += 10;
                if(container.Height >= 200)
                {
                    accounttabexpand.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                if(container.Height != 50)
                {
                    container.Height -= 10;
                }
                if(container.Height <= 50)
                {
                    accounttabexpand.Stop();
                    menuExpand = false;
                }
            }
        }

        private void makeAnsmnt_btn_Click(object sender, EventArgs e)
        {
            composeAnnoucement uc = new composeAnnoucement();
            addUserControl(uc);
        }

        private void posted_eve_btn_Click(object sender, EventArgs e)
        {
            PopulateCustomListWithResidents();
        }

        private void Summaries_Click(object sender, EventArgs e)
        {
            summaries_uc open = new summaries_uc();
            addUserControl(open);
        }
    }
    public class ResidentData
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public string What { get; set; }
        public string Who { get; set; }
        public DateTime When { get; set; }
        public string Where { get; set; }
        public string Why { get; set; }
        public string How { get; set; }
    }
    public class employee_acc_details
    {
        public int primary_key { get; set; }
        public string emp_name { get; set; }
        public string emp_pass { get; set; }
        public DateTime emp_birthdate { get; set; }
        public int emp_age { get; set; }
        public string emp_sex { get; set; }
        public int emp_ID { get; set; }
    }
}
