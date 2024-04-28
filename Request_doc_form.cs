using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Request_doc_form : Form
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public Request_doc_form()
        {
            InitializeComponent();
        }

        // this is the send button to send the inputed data to the database.
        private void send_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);

            string query = "INSERT INTO req_document_db (req_ID, Name_of_resident, date, doc_requested, purpose) VALUES (NULL, @name, @date, @doc_request, @purpose)";

            MySqlCommand com = new MySqlCommand(query, con);

            string name = req_name_tbx.Text;
            string req_doc = req_doc_dpdn.Text;
            string purpose = purpose_tbx.Text;

            try
            {
                con.Open();

                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@date", DateTime.Now);
                com.Parameters.AddWithValue("@doc_request", req_doc);
                com.Parameters.AddWithValue("@purpose", purpose);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request successfully sent");
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

        // this is a close button for the request form.
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // this is a cancel button for the request forn.
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            req_name_tbx.Clear();
            req_doc_dpdn.Text = null;
            purpose_tbx.Clear();
        }

    }
}
