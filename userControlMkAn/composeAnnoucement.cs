using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.userControlMkAn
{
    //commit test
    public partial class composeAnnoucement : UserControl
    {
        string database = "server = localhost; user = root; database = resident_database; sslMode = none;";
        public composeAnnoucement()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void post_btn_Click(object sender, EventArgs e)
        {

        }

        private void composeAnnoucement_Load(object sender, EventArgs e)
        {

        }

        //adding image to the post.
        private void upload_btn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    event_Image_pbx.ImageLocation = imageLocation;
                }
                event_Image_pbx.BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //button for posting events in the employee dashboard.
        private void post_btn_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database);
            try
            {
                MemoryStream ms = new MemoryStream();
                event_Image_pbx.Image.Save(ms, event_Image_pbx.Image.RawFormat);
                byte[] pImg = ms.ToArray();

                string pwhat = eve_what_tbx.Text.ToString();
                string pwho = eve_who_tbx.Text.ToString();
                string pwhen = eve_when_from_dtp.Text.ToString();
                string pwhere = eve_where_tbx.Text.ToString();
                string pwhy = eve_why_tbx.Text.ToString();
                string phow = eve_how_tbx.Text.ToString();

                string  query = $"INSERT INTO `posted_events`(`post_id`, `post_img`, `post_what`, `post_who`, `post_when`, `post_where`, `post_why`, `post_how`) VALUES (NULL,'@post_img', '{pwhat}', '{pwho}', '{pwhen}', '{pwhere}', '{pwhy}', '{phow}')";
                MySqlCommand cmd = new MySqlCommand(query, con);

               
                cmd.Parameters.AddWithValue("@post_img", pImg);
                cmd.Parameters.AddWithValue("post_what", pwhat);
                cmd.Parameters.AddWithValue("post_who", pwho);
                cmd.Parameters.AddWithValue("post_when", pwhen);
                cmd.Parameters.AddWithValue("post_where", pwhere);
                cmd.Parameters.AddWithValue("post_why", pwhy);
                cmd.Parameters.AddWithValue("Post_how", phow);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if(rowsAffected > 0)
                {
                    MessageBox.Show("You have successfully created a post");
                    event_Image_pbx.Image = null;
                    event_initial_pbx.BringToFront();
                    eve_what_tbx.Clear();
                    eve_who_tbx.Clear();
                    eve_when_from_dtp.Value = DateTimePicker.MinimumDateTime;
                    eve_where_tbx.Clear();
                    eve_why_tbx.Clear();
                    eve_how_tbx.Clear();
                }
                else
                {
                    MessageBox.Show("Execution failed");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er + "Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void eve_when_from_dtp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
