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

namespace WindowsFormsApp1.employee_tabs_controls
{
    public partial class document_req_log : UserControl
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public document_req_log()
        {
            InitializeComponent();
        }

        private void blotter_log_Load(object sender, EventArgs e)
        {
            datapopulator();
        }

        private void ClearDataGridView()
        {
            blotters.Rows.Clear();
        }

        // method to populate the datagridview with the data from the database and show it to the graphs.
        private void datapopulator()
        {
            ClearDataGridView();
            MySqlConnection con = new MySqlConnection(database);

            string query = "SELECT * FROM req_document_db";
            MySqlCommand com = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataReader reader = com.ExecuteReader();

                int rowi = 0;
                while (reader.Read())
                {
                    blotters.Rows.Add();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"Field: {reader.GetName(i)}, Type: {reader.GetFieldType(i)}");
                    }
                    blotters["full_name", rowi].Value = reader.GetString("Name_of_resident");
                    blotters["date", rowi].Value = reader.GetDateTime("date").ToString("yyyy-MM-dd");
                    blotters["document_request", rowi].Value = reader.GetString("doc_requested");
                    blotters["purpose", rowi].Value = reader.GetString("purpose");

                    rowi++;
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

        // code for the search_box.
        private void searchbox_tbx_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToLower();

            try
            {
                foreach (DataGridViewRow row in blotters.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool rowVisible = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(search))
                            {
                                rowVisible = true;
                                break;
                            }
                        }
                        row.Visible = rowVisible;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // this will clear the searchbox once the user clicks on it.
        private void searchbox_tbx_Click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = string.Empty;
            textbox.ForeColor = Color.FromArgb(17, 35, 90);
            textbox.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        // this will set the text of the label in the viewer area to be viewed.
        private void blotters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = blotters.Rows[e.RowIndex];

                name_lbl.Text = row.Cells["full_name"].Value.ToString();
                date_lbl.Text = row.Cells["Date"].Value.ToString();
                document_lbl.Text = row.Cells["document_request"].Value.ToString();
                purpose_lbl.Text = row.Cells["purpose"].Value.ToString();
            }
        }
    }
}
