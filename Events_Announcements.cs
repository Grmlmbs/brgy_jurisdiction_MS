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
using WindowsFormsApp1.employee_tabs_controls;

namespace WindowsFormsApp1
{
    public partial class residentDashboard : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public residentDashboard()
        {
            InitializeComponent();
            PopulateCustomListWithResidents();
        }
        private void addUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(UserControl);
            UserControl.BringToFront();
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
        private void Home_btn_Load(object sender, EventArgs e)
        {

        }
        // a button for opening the account details.
        private void account_Click(object sender, EventArgs e)
        {
            account_btn_drpdwn_animation.Start();
        }

        // this button will open a new form that would show the resident's info.
        private void button1_Click(object sender, EventArgs e)
        {
            Abt_account open = new Abt_account();
            addUserControl(open);
        }
        bool menuexpand = true;
        private void account_btn_drpdwn_anmation_Tick(object sender, EventArgs e)
        {
            if (menuexpand == false)
            {
                Account_drpdown_pnl.Height += 10;
                if (Account_drpdown_pnl.Height >= 150)
                {
                    account_btn_drpdwn_animation.Stop();
                    menuexpand = true;
                }
            }
            else
            {
                if(Account_drpdown_pnl.Height != 50)
                {
                    Account_drpdown_pnl.Height -= 10;
                }
                if (Account_drpdown_pnl.Height <= 50)
                {
                    account_btn_drpdwn_animation.Stop();
                    menuexpand = false;
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            PopulateCustomListWithResidents();
            if (Account_drpdown_pnl.Height == 150)
            {
                account_btn_drpdwn_animation.Start();
            }
        }

        private void Notification_btn_Click(object sender, EventArgs e)
        {
            if(Account_drpdown_pnl.Height == 150)
            {
                account_btn_drpdwn_animation.Start();
            }
        }

        private void req_doc_btn_Click(object sender, EventArgs e)
        {
            if(Account_drpdown_pnl.Height == 150)
            {
                account_btn_drpdwn_animation.Start();
            }
        }

        private void Blotter_btn_Click(object sender, EventArgs e)
        {
            if(Account_drpdown_pnl.Height == 150)
            {
                account_btn_drpdwn_animation.Start();
            }
        }

        private void concern_btn_Click(object sender, EventArgs e)
        {
            if (Account_drpdown_pnl.Height == 150)
            {
                account_btn_drpdwn_animation.Start();
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
