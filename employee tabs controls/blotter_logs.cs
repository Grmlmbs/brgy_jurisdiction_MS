using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.employee_tabs_controls
{
    public partial class blotter_logs : UserControl
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none";
        public blotter_logs()
        {
            InitializeComponent();
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

            string query = "SELECT * FROM blotters_db";
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
                    blotters["com_name", rowi].Value = reader.GetString("com_name");
                    blotters["def_name", rowi].Value = reader.GetString("def_name");
                    blotters["date_happ", rowi].Value = reader.GetDateTime("date_happened").ToString("yyyy-MM-dd");
                    blotters["narration", rowi].Value = reader.GetString("Narration");

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
        private void blotter_logs_Load(object sender, EventArgs e)
        {
            datapopulator();
        }

        // this is a searchbox for the blotter's logs
        private void blotter_searchbox_tbx_TextChanged(object sender, EventArgs e)
        {
            string search = blotter_searchbox_tbx.Text.ToLower();

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

        // this would clear the searchbox when perssed.
        private void blotter_searchbox_tbx_Click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = string.Empty;
            textbox.ForeColor = Color.FromArgb(17, 35, 90);
            textbox.Font = new Font(blotter_searchbox_tbx.Font, FontStyle.Regular);
        }

        // this would set the text inside the label when a certain row is clicked.
        private void blotters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = blotters.Rows[e.RowIndex];

                com_name_lbl.Text = row.Cells["com_name"].Value.ToString();
                defendant_name_lbl.Text = row.Cells["def_name"].Value.ToString();
                date_happened_lbl.Text = row.Cells["date_happ"].Value.ToString();
                narration_lbl.Text = row.Cells["narration"].Value.ToString();
            }
        }
    }
}
