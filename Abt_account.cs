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
                if (user._acc_name != null)
                {
                    acc_name_tbx.Enabled = false;
                }
                if (user._acc_pass != null)
                {
                    pass_tbx.Enabled = false;
                }
                if (user._phone_no != 0)
                {
                    phone_num_tbx.Enabled = false;
                }
                if (user._fname != null)
                {
                    fname_tbx.Enabled = false;
                }
                if (user._Lname != null)
                {
                    Lname_tbx.Enabled = false;
                }
                if (user._age != 0)
                {
                    age_cmbx.Enabled = false;
                }
                if (user._birthdate.ToString() != null)
                {
                    birthdate_dtp.Enabled = false;
                }
                if (user._sex != null)
                {
                    acc_sex.Enabled = false;
                }
                if (user._voter_status != null)
                {
                    voter_status.Enabled = false;
                }
                if (user._vacc_status != null)
                {
                    vacc_status.Enabled = false;
                }
                if (user._address != null)
                {
                    Address_tbx.Enabled = false;
                }
                if (user._marital_status != null)
                {
                    Marital_status.Enabled = false;
                }
                if (user._no_of_fam != 0)
                {
                    num_fam.Enabled = false;
                }
                if (user._mon_income == 0 || user._mon_income == null)
                {
                    monthly_income.Enabled = false;
                }
                if (user._educ_attain != null)
                {
                    educ_attain.Enabled = false;
                }
                if (user._occupation != null)
                {
                    occupation_tbx.Enabled = false;
                }
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
