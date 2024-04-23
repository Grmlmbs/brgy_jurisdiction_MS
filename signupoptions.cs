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
    public partial class signupoptions : Form
    {
        public signupoptions()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void res_signup_btn_Click(object sender, EventArgs e)
        {
            signup resident = new signup();
            resident.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 employee = new Form2();
            employee.Show();
            this.Close();
        }

        private void signupoptions_Load(object sender, EventArgs e)
        {

        }

        private void animations_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1.0)
            {
                animations.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }
    }
}
