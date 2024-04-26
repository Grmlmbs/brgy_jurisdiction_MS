using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.employee_tabs_controls
{
    internal class Datapopulator
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";

        // this method class will be used to populate the charts and gridviews in the summaries tab;
        public DataTable Dataretriever(string query)
        {
            DataTable data = new DataTable();
            using (MySqlConnection con = new MySqlConnection(database))
            {
                using (MySqlCommand com = new MySqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                        adapter.Fill(data);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data " + ex.Message + " Error");
                    }
                }
            }
            return data;
        }
    }
}
