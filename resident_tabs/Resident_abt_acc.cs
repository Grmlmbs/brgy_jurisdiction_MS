using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.resident_tabs
{
    public partial class Resident_abt_acc : UserControl
    {

        public Resident_abt_acc()
        {
            InitializeComponent();
        }

        // this will populate the user control for the about accound with the necessary info depending on the account.
        public void enteruserdetails(Accountdetails user)
        {
            try
            {
                if (user._profile_pic != null && user._profile_pic.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(user._profile_pic))
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        profile_pic_pbx.Image = Image.FromStream(ms);
                    }
                }
                res_acc_name.Text = user._acc_name;
                res_acc_pass.Text = user._acc_pass;
                res_acc_phone.Text = Convert.ToString(user._phone_no);
                res_acc_fname.Text = user._fname;
                res_acc_lname.Text = user._Lname;
                res_acc_bdate.Text = user._birthdate.ToString("yyyy-MM-dd");
                res_acc_age.Text = user._age.ToString();
                res_acc_sex.Text = user._sex;
                res_acc_Vstatus.Text = user._voter_status;
                res_acc_vaccstatus.Text = user._vacc_status;
                res_acc_address.Text = user._address;
                res_acc_Mstatus.Text = user._marital_status;
                res_acc_nooffam.Text = user._no_of_fam.ToString();
                res_acc_income.Text = user._mon_income.ToString();
                res_acc_educattain.Text = user._educ_attain;
                res_acc_occu.Text = user._occupation;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
        }
        // this will censor the password.
        private void res_acc_pass_Paint(object sender, PaintEventArgs e)
        {
            Label pass_label = (Label)sender;
            Graphics g = e.Graphics;
            SizeF size = g.MeasureString("*", pass_label.Font);

            float startX = 0;
            float startY = (pass_label.Height - size.Height) / 2;
            float charWidth = size.Width;

            Color customColor = Color.FromArgb(240, 237, 207);
            SolidBrush brush = new SolidBrush(customColor);
            Pen pen = new Pen(customColor);

            Rectangle rect = new Rectangle(0, 0, pass_label.Width - 1, pass_label.Height - 1);
            g.FillRectangle(brush, rect);
            g.DrawRectangle(pen, rect);

            for (int i = 0; i < pass_label.Text.Length; i++)
            {
                g.DrawString("*", pass_label.Font, brush, startX, startY);
                startX += charWidth;
            }

            brush.Dispose();
            pen.Dispose();
        }
    }
}
