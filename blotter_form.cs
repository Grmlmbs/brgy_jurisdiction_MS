using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class blotter_form : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public blotter_form()
        {
            InitializeComponent();
        }

        // this button will send all the filled in data to the database.
        private void blotter_send_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);

            string query = "INSERT INTO blotters_db(blotter_ID, com_name, def_name, date_happened, Narration) VALUES (NULL, @com_name, @def_name, @date_happened, @Narration)";

            MySqlCommand com = new MySqlCommand(query, con);

            string com_name = com_name_tbx.Text.ToString();
            string def_name = def_name_tbx.Text.ToString();
            string date_happ = date_happened.Text.ToString();
            string narration = narration_tbx.Text.ToString();

            try
            {
                con.Open();

                com.Parameters.AddWithValue("@com_name", com_name);
                com.Parameters.AddWithValue("@def_name", def_name);
                com.Parameters.AddWithValue("@date_happened", date_happ);
                com.Parameters.AddWithValue("@Narration", narration);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request successfully sent");
                    com_name_tbx.Clear();
                    def_name_tbx.Clear();
                    date_happened.Value = DateTime.Now;
                    narration_tbx.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to send request");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Error");
            }
            finally
            {
                con.Close();
            }
        }
        // this will close the form on click.
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blotter_cancel_btn_Click(object sender, EventArgs e)
        {
            com_name_tbx.Clear();
            def_name_tbx.Clear();
            date_happened.Value = DateTime.Now;
            narration_tbx.Clear();
        }
    }
}
