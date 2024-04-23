using MySql.Data.MySqlClient;
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

namespace WindowsFormsApp1
{
    public partial class Abt_account : UserControl
    {
        public Abt_account()
        {
            InitializeComponent();
        }
        //this method will take the retrieved data to it's designated controls.
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
                acc_name_tbx.Text = user._acc_name;
                pass_tbx.Text = user._acc_pass;
                phone_num_tbx.Text = Convert.ToString(user._phone_no);
                fname_tbx.Text = user._fname;
                Lname_tbx.Text = user._Lname;
                birthdate_dtp.Text = user._birthdate.ToString();
                age_cmbx.Value = user._age;
                acc_sex.Text = user._sex;
                voter_status.Text = user._voter_status;
                vacc_status.Text = user._vacc_status;
                Address_tbx.Text = user._address;
                Marital_status.Text = user._marital_status;
                num_fam.Value = user._no_of_fam;
                monthly_income.Text = user._mon_income.ToString();
                educ_attain.Text = user._educ_attain;
                occupation_tbx.Text = user._occupation;
            }
            catch (Exception er)
            {
                MessageBox.Show(er + "Error");
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Abt_account_Load(object sender, EventArgs e)
        {

        }
    }
}
