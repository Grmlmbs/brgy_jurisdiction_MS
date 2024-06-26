﻿using System;
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
using LiveCharts;
using System.Windows.Documents;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Charts;

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

        // method to populate the datagridview with the data from the database and show it to the graphs.
        private void datapopulator()
        {
            ClearDataGridView();
            MySqlConnection con = new MySqlConnection(database);

            string query = "SELECT * FROM accounts";
            MySqlCommand com = new MySqlCommand(query, con);
            try
            {
                int population = 0;
                int male = 0;
                int female = 0;
                int child = 0;
                int adult = 0;
                int senior = 0;
                int married = 0;
                int single = 0;
                int reg = 0;
                int unreg = 0;
                int no_formal = 0;
                int primary = 0;
                int secondary = 0;
                int high_school = 0;
                int undergrad = 0;
                int collegegrad = 0;
                int employed = 0;
                int selfemp = 0;
                int unemp = 0;
                int vacc = 0;
                int unvacc = 0;

                con.Open();
                MySqlDataReader reader = com.ExecuteReader();

                int rowIndex = 0;
                while (reader.Read())
                {
                    Residents.Rows.Add();

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

                    population++;
                    if (Residents["res_acc_occupation", rowIndex].Value.ToString() == "Unemployed")
                    {
                        unemp++;
                    }
                    else if (Residents["res_acc_occupation", rowIndex].Value.ToString() == "Self-employed")
                    {
                        selfemp++;
                    }
                    else
                    {
                        unemp++;
                    }

                    if(Residents["vacc_status", rowIndex].Value.ToString() == "Vaccinated")
                    {
                        vacc++;
                    }
                    else
                    {
                        unvacc++;
                    }

                    if(Residents["educ_attainment", rowIndex].Value.ToString() == "No Formal Education")
                    {
                        no_formal++;
                    }
                    else if(Residents["educ_attainment", rowIndex].Value.ToString() == "Primary Education")
                    {
                        primary++;
                    }
                    else if(Residents["educ_attainment", rowIndex].Value.ToString() == "Secondary Education")
                    {
                        secondary++;
                    }
                    else if(Residents["educ_attainment", rowIndex].Value.ToString() == "High School Diploma or Equivalent")
                    {
                        high_school++;
                    }
                    else if (Residents["educ_attainment", rowIndex].Value.ToString() == "Undergraduate")
                    {
                        undergrad++;
                    }
                    else
                    {
                        collegegrad++;
                    }

                    if (Residents["Voter_status", rowIndex].Value.ToString() == "Registered")
                    {
                        reg++;
                    }
                    else
                    {
                        unreg++;
                    }

                    if (Convert.ToInt32(Residents["res_acc_age", rowIndex].Value) > 0 && Convert.ToInt32(Residents["res_acc_age", rowIndex].Value) <= 17)
                    {
                        child++;
                    }
                    else if(Convert.ToInt32(Residents["res_acc_age", rowIndex].Value) > 18 && Convert.ToInt32(Residents["res_acc_age", rowIndex].Value) <= 59)
                    {
                        adult++;
                    }
                    else
                    {
                        senior++;
                    }

                    if (Residents["res_acc_sex", rowIndex].Value.ToString() == "Female")
                    {
                        female++;
                    }
                    else
                    {
                        male++;
                    }

                    if (Residents["marital_status", rowIndex].Value.ToString() == "Married")
                    {
                        married++;
                    }
                    else
                    {
                        single++;
                    }
                    rowIndex++;

                }
                vacc_lbl.Text = Convert.ToString(vacc);
                unvacc_lbl.Text = Convert.ToString(unvacc);

                vacc_chart.Titles.Add("Vaccination status");
                vacc_chart.Series["Vaccination status"].Points.AddXY("V", vacc);
                vacc_chart.Series["Vaccination status"].Points.AddXY("UV", unvacc);

                employed_lbl.Text = Convert.ToString(employed);
                unemployed_lbl.Text = Convert.ToString(unemp);
                self_emp_lbl.Text = Convert.ToString(selfemp);

                occu_chart .Titles.Add("Occupation");
                occu_chart.Series["occupation"].Points.AddXY("E", employed);
                occu_chart.Series["occupation"].Points.AddXY("UE", unemp);
                occu_chart.Series["occupation"].Points.AddXY("SE", selfemp);

                no_formal_ed_lbl.Text = Convert.ToString(no_formal);
                primary_lbl.Text = Convert.ToString(primary);
                secondary_lbl.Text = Convert.ToString(secondary);
                high_school_lbl.Text = Convert.ToString(high_school);
                undergrad_lbl.Text = Convert.ToString(undergrad);
                college_grad_lbl.Text = Convert.ToString(collegegrad);

                educational_attain_chart.Titles.Add("Educational Attainment");
                educational_attain_chart.Series["educational attainment"].Points.AddXY("NFE", no_formal);
                educational_attain_chart.Series["educational attainment"].Points.AddXY("PE", primary);
                educational_attain_chart.Series["educational attainment"].Points.AddXY("SE", secondary);
                educational_attain_chart.Series["educational attainment"].Points.AddXY("HS", high_school);
                educational_attain_chart.Series["educational attainment"].Points.AddXY("UG", undergrad);
                educational_attain_chart.Series["educational attainment"].Points.AddXY("CG", collegegrad);

                reg_lbl.Text = Convert.ToString(reg);
                unreg_lbl.Text = Convert.ToString(unreg);

                v_status_chart.Titles.Add("Voter");
                v_status_chart.Series["Voter status"].Points.AddXY("R", reg);
                v_status_chart.Series["Voter status"].Points.AddXY("UR", unreg);

                Tpopulation_lbl.Text = Convert.ToString(population);
                male_count_lbl.Text = Convert.ToString(male);
                female_count_lbl.Text = Convert.ToString(female);

                sex_pchart.Titles.Add("Gender");
                sex_pchart.Series["Gender"].Points.AddXY("M", male);
                sex_pchart.Series["Gender"].Points.AddXY("F", female);
                
                child_lbl.Text = Convert.ToString(child);
                adult_lbl.Text = Convert.ToString(adult);
                senior_lbl.Text = Convert.ToString(senior);

                age_chart.Titles.Add("Age distribution");
                age_chart.Series["age"].Points.AddXY("C", child);
                age_chart.Series["age"].Points.AddXY("A", adult);
                age_chart.Series["age"].Points.AddXY("S", senior);

                married_lbl.Text = Convert.ToString(married);
                single_lbl.Text = Convert.ToString(single);

                m_status_chart.Titles.Add("Marital status");
                m_status_chart.Series["Marital status"].Points.AddXY("M", married);
                m_status_chart.Series["Marital status"].Points.AddXY("S", single);
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
                return Properties.Resources.profile_dflt2;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading image: " + ex.Message);

                return Properties.Resources.profile_dflt2;
            }
        }

        // the user control.
        private void summaries_uc_Load(object sender, EventArgs e)
        {
            datapopulator();
        }

        // this is a codeblock for the searchbox.
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
        private void searchbox_tbx_Click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Text = string.Empty;
            textbox.ForeColor = Color.FromArgb(17, 35, 90);
            textbox.Font= new Font(searchbox_tbx.Font, FontStyle.Regular);
        }

        // this will retrieve the resident ID to be used later in the query to populate the registration form for the necessary data
        private void Residents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selected = Residents.Rows[e.RowIndex];

                    string cell_in_resident_ID = selected.Cells["Resident_ID"].Value.ToString();

                    Abt_account.enteruserdetails(cell_in_resident_ID);
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
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

        // this button will be used to update the edited profile of the resident.
        private void update_btn_Click(object sender, EventArgs e)
        {

            if (Residents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = Residents.SelectedRows[0];

                DataGridViewRow selectedRow = Residents.SelectedRows[0];

                object res_ID_value = selectedRow.Cells["Resident_ID"].Value;
                string res_ID_asString = Convert.ToString(res_ID_value);

                if (String.IsNullOrEmpty(res_ID_asString))
                {
                    MessageBox.Show("This Row is empty: \nPlease select another row to edit.");
                }  
                else
                {
                    edit_profile updateForm = new edit_profile();

                    updateForm.SelectedRowData = new Dictionary<string, object>();
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        updateForm.SelectedRowData[cell.OwningColumn.Name] = cell.Value;
                    }
                    DialogResult result = updateForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
