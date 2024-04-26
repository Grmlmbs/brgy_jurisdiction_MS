using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.IO;
using System.Windows.Documents;

namespace WindowsFormsApp1.employee_tabs_controls
{
    public partial class summaries_uc : UserControl
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public summaries_uc()
        {
            InitializeComponent();
        }
        // this is a method to clear the datagridview before it gets loaded.
        private void ClearDataGridView()
        {
            Residents.Rows.Clear();
        }

        // method to populate the datagridview with the data from the database.
        private void datapopulator()
        {
            ClearDataGridView();
            MySqlConnection con = new MySqlConnection(database);

            string query = "SELECT * FROM accounts";
            MySqlCommand com = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataReader reader = com.ExecuteReader();

                int rowIndex = 0;
                while (reader.Read())
                {
                    Residents.Rows.Add();
                    // Debug: Print out field names and data types
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"Field: {reader.GetName(i)}, Type: {reader.GetFieldType(i)}");
                    }

                    Residents["Resident_ID", rowIndex].Value = reader.GetInt32("accID").ToString();
                    Residents["Profile_picture", rowIndex].Value = ConvertToImage((byte[])reader["Profile_pic"]);
                    Residents["First_name", rowIndex].Value = reader.GetString("first_name");
                    Residents["Last_name", rowIndex].Value = reader.GetString("last_name");
                    Residents["res_name", rowIndex].Value = reader.GetString("name");
                    Residents["res_acc_password", rowIndex].Value = reader.GetString("password");
                    Residents["res_acc_birthdate", rowIndex].Value = reader.GetDateTime("Birthdate").ToString("yyyy-MM-dd");
                    Residents["res_acc_age", rowIndex].Value = reader.GetInt32("age");
                    Residents["res_acc_sex", rowIndex].Value = reader.GetString("sex");
                    Residents["res_acc_address", rowIndex].Value = reader.GetString("Address");
                    Residents["Tel_no", rowIndex].Value = reader.GetString("Telephone_no");
                    Residents["Voter_status", rowIndex].Value = reader.GetString("Voter_status");
                    Residents["marital_status", rowIndex].Value = reader.GetString("Marital_status");
                    Residents["no_of_fam_mem", rowIndex].Value = reader.GetInt32("No_of_fam_mem");
                    Residents["mon_income", rowIndex].Value = reader.GetInt32("Mon_income");
                    Residents["educ_attainment", rowIndex].Value = reader.GetString("educational_attainment");
                    Residents["res_acc_occupation", rowIndex].Value = reader.GetString("occupation");
                    Residents["vacc_status", rowIndex].Value = reader.GetString("vaccination_status");

                    rowIndex++;
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
        // This methd will convert the byte array into an image.
        private Image ConvertToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Residents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // the user control.
        private void summaries_uc_Load(object sender, EventArgs e)
        {
            datapopulator();
        }

        // this is a codeblock for the searbox.
        private void seachbox_tbx_TextChanged(object sender, EventArgs e)
        {
            string search = searchbox_tbx.Text.ToLower();

            try
            {
                foreach (DataGridViewRow row in Residents.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool rowvisible = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(search))
                            {
                                rowvisible = true;
                                break;
                            }
                        }
                        row.Visible = rowvisible;
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er + "Error");
            }
        }
        /*        
        Birthdate, Age, Sex: Suitable for demographic charts like bar charts or pie charts.
        Voter Status: Suitable for a pie chart.
        Marital Status: Suitable for a pie chart or bar chart.
        Number of Family Members: Suitable for a bar chart or histogram.
        Monthly Income: Suitable for a histogram or box plot.
        Educational Attainment: Suitable for a bar chart or pie chart.
        Occupation: Suitable for a bar chart or pie chart.
        Vaccination Status: Suitable for a pie chart.
        */
        private void searchbox_tbx_Click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = string.Empty;
            textbox.ForeColor = Color.FromArgb(17, 35, 90);
            textbox.Font= new Font(searchbox_tbx.Font, FontStyle.Regular);
        }

        private void Residents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selected = Residents.Rows[e.RowIndex];

                string cell_in_resident_ID = selected.Cells["Resident_ID"].Value.ToString();

                Abt_account.enteruserdetails(cell_in_resident_ID);
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            registration_form open = new registration_form();
            open.Show();
            open.BringToFront();
        }

        // this is a button to refresh the datagridview.

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            datapopulator();
        }

        // this is a button for deleting data.
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (Residents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Residents.SelectedRows[0];

                int accID = Convert.ToInt32(selectedRow.Cells["Resident_ID"].Value);

                string query = "DELETE FROM accounts WHERE accID = @accID";

                using (MySqlConnection con = new MySqlConnection(database))
                {

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@accID", accID);

                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Residents.Rows.Remove(selectedRow);
                                MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while deleting the row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
