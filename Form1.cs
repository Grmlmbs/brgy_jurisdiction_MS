using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //this is a button for the resident log in opetion
        private void button1_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            try
            {
                using (login login = new login())
                {
                    FormBackground.StartPosition = FormStartPosition.CenterScreen;
                    FormBackground.FormBorderStyle = FormBorderStyle.None;
                    FormBackground.Opacity = .70d;
                    FormBackground.BackColor = Color.Black;
                    FormBackground.TopMost = true;
                    FormBackground.Width = 750;
                    FormBackground.Height = 471;
                    FormBackground.ShowInTaskbar = false;
                    FormBackground.Owner = this;
                    FormBackground.Show();

                    login.Owner = FormBackground;
                    login.ShowDialog();

                    FormBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormBackground.Dispose();
            }
        }
        int imagenum = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            events.Image = imglist_events.Images[imagenum];
            if(imagenum == imglist_events.Images.Count - 1)
            {
                imagenum = 0;
            }
            else
            {
                imagenum++;
            }
        }

        // a button for employee log in option.
        private void button2_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            try
            {
                using (employee_login emplogin = new employee_login())
                {
                    Background.StartPosition = FormStartPosition.CenterScreen;
                    Background.FormBorderStyle = FormBorderStyle.None;
                    Background.Opacity = .70d;
                    Background.BackColor = Color.Black;
                    Background.TopMost = true;
                    Background.Width = 750;
                    Background.Height = 471;
                    Background.ShowInTaskbar = false;
                    Background.Owner = this;
                    Background.Show();

                    emplogin.Owner = Background;
                    emplogin.ShowDialog();

                    Background.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Background.Dispose();
            }
        }

        // a button for sign up.
        private void button3_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            try
            {
                using (signupoptions Spoptions = new signupoptions())
                {
                    Background.StartPosition = FormStartPosition.CenterScreen;
                    Background.FormBorderStyle = FormBorderStyle.None;
                    Background.Opacity = .70d;
                    Background.BackColor = Color.Black;
                    Background.TopMost = true;
                    Background.Width = 750;
                    Background.Height = 471;
                    Background.ShowInTaskbar = false;
                    Background.Owner = this;
                    Background.Show();

                    Spoptions.Owner = Background;
                    Spoptions.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Background.Dispose();
            }
        }

        private void animation_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1.0)
            {
                animation.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        private void events_Click(object sender, EventArgs e)
        {

        }
    } 
}
