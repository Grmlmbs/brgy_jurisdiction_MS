namespace WindowsFormsApp1.employee_tabs_controls
{
    partial class summaries_uc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(summaries_uc));
            this.Residents = new System.Windows.Forms.DataGridView();
            this.Resident_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profile_picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voter_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_of_fam_mem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon_income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educ_attainment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_acc_occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacc_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox_tbx = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tpopulation_lbl = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.Residents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Residents
            // 
            this.Residents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Residents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Residents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resident_ID,
            this.Profile_picture,
            this.First_name,
            this.Last_name,
            this.res_name,
            this.res_acc_password,
            this.res_acc_birthdate,
            this.res_acc_age,
            this.res_acc_sex,
            this.res_acc_address,
            this.Tel_no,
            this.Voter_status,
            this.marital_status,
            this.no_of_fam_mem,
            this.mon_income,
            this.educ_attainment,
            this.res_acc_occupation,
            this.vacc_status});
            this.Residents.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Residents.Location = new System.Drawing.Point(21, 101);
            this.Residents.MultiSelect = false;
            this.Residents.Name = "Residents";
            this.Residents.ReadOnly = true;
            this.Residents.Size = new System.Drawing.Size(823, 239);
            this.Residents.TabIndex = 1;
            this.Residents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Residents_CellClick);
            this.Residents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Residents_CellContentClick);
            // 
            // Resident_ID
            // 
            this.Resident_ID.Frozen = true;
            this.Resident_ID.HeaderText = "Resident ID";
            this.Resident_ID.Name = "Resident_ID";
            this.Resident_ID.ReadOnly = true;
            // 
            // Profile_picture
            // 
            this.Profile_picture.Frozen = true;
            this.Profile_picture.HeaderText = "Profile picture";
            this.Profile_picture.Name = "Profile_picture";
            this.Profile_picture.ReadOnly = true;
            // 
            // First_name
            // 
            this.First_name.Frozen = true;
            this.First_name.HeaderText = "First Name";
            this.First_name.Name = "First_name";
            this.First_name.ReadOnly = true;
            // 
            // Last_name
            // 
            this.Last_name.Frozen = true;
            this.Last_name.HeaderText = "Last name";
            this.Last_name.Name = "Last_name";
            this.Last_name.ReadOnly = true;
            // 
            // res_name
            // 
            this.res_name.Frozen = true;
            this.res_name.HeaderText = "Full Name";
            this.res_name.Name = "res_name";
            this.res_name.ReadOnly = true;
            // 
            // res_acc_password
            // 
            this.res_acc_password.HeaderText = "Password";
            this.res_acc_password.Name = "res_acc_password";
            this.res_acc_password.ReadOnly = true;
            // 
            // res_acc_birthdate
            // 
            this.res_acc_birthdate.HeaderText = "Birthdate";
            this.res_acc_birthdate.Name = "res_acc_birthdate";
            this.res_acc_birthdate.ReadOnly = true;
            // 
            // res_acc_age
            // 
            this.res_acc_age.HeaderText = "Age";
            this.res_acc_age.Name = "res_acc_age";
            this.res_acc_age.ReadOnly = true;
            // 
            // res_acc_sex
            // 
            this.res_acc_sex.HeaderText = "Sex";
            this.res_acc_sex.Name = "res_acc_sex";
            this.res_acc_sex.ReadOnly = true;
            // 
            // res_acc_address
            // 
            this.res_acc_address.HeaderText = "Address";
            this.res_acc_address.Name = "res_acc_address";
            this.res_acc_address.ReadOnly = true;
            // 
            // Tel_no
            // 
            this.Tel_no.HeaderText = "Cellphone #";
            this.Tel_no.Name = "Tel_no";
            this.Tel_no.ReadOnly = true;
            // 
            // Voter_status
            // 
            this.Voter_status.HeaderText = "Voter Status";
            this.Voter_status.Name = "Voter_status";
            this.Voter_status.ReadOnly = true;
            // 
            // marital_status
            // 
            this.marital_status.HeaderText = "Marital Status";
            this.marital_status.Name = "marital_status";
            this.marital_status.ReadOnly = true;
            // 
            // no_of_fam_mem
            // 
            this.no_of_fam_mem.HeaderText = "No. of family member";
            this.no_of_fam_mem.Name = "no_of_fam_mem";
            this.no_of_fam_mem.ReadOnly = true;
            // 
            // mon_income
            // 
            this.mon_income.HeaderText = "Monthly Income";
            this.mon_income.Name = "mon_income";
            this.mon_income.ReadOnly = true;
            // 
            // educ_attainment
            // 
            this.educ_attainment.HeaderText = "Educational attianment";
            this.educ_attainment.Name = "educ_attainment";
            this.educ_attainment.ReadOnly = true;
            // 
            // res_acc_occupation
            // 
            this.res_acc_occupation.HeaderText = "Occupation";
            this.res_acc_occupation.Name = "res_acc_occupation";
            this.res_acc_occupation.ReadOnly = true;
            // 
            // vacc_status
            // 
            this.vacc_status.HeaderText = "Vacination status";
            this.vacc_status.Name = "vacc_status";
            this.vacc_status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barangay\'s profile";
            // 
            // searchbox_tbx
            // 
            this.searchbox_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox_tbx.ForeColor = System.Drawing.Color.DimGray;
            this.searchbox_tbx.Location = new System.Drawing.Point(47, 66);
            this.searchbox_tbx.Name = "searchbox_tbx";
            this.searchbox_tbx.Size = new System.Drawing.Size(233, 18);
            this.searchbox_tbx.TabIndex = 5;
            this.searchbox_tbx.Text = "search for a name...";
            this.searchbox_tbx.Click += new System.EventHandler(this.searchbox_tbx_Click);
            this.searchbox_tbx.TextChanged += new System.EventHandler(this.seachbox_tbx_TextChanged);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(504, 63);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(0);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(78, 25);
            this.refresh_btn.TabIndex = 8;
            this.refresh_btn.Text = "      Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Register_btn.FlatAppearance.BorderSize = 0;
            this.Register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Register_btn.Image = ((System.Drawing.Image)(resources.GetObject("Register_btn.Image")));
            this.Register_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Register_btn.Location = new System.Drawing.Point(591, 63);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(78, 25);
            this.Register_btn.TabIndex = 7;
            this.Register_btn.Text = "Register";
            this.Register_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.update_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_btn.Image")));
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(679, 63);
            this.update_btn.Margin = new System.Windows.Forms.Padding(0);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(78, 25);
            this.update_btn.TabIndex = 7;
            this.update_btn.Text = "     Edit";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(766, 63);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(78, 25);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "     Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(63, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Population Dynamics";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(43, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total population:";
            // 
            // Tpopulation_lbl
            // 
            this.Tpopulation_lbl.AutoSize = true;
            this.Tpopulation_lbl.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpopulation_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Tpopulation_lbl.Location = new System.Drawing.Point(37, 438);
            this.Tpopulation_lbl.Name = "Tpopulation_lbl";
            this.Tpopulation_lbl.Size = new System.Drawing.Size(130, 58);
            this.Tpopulation_lbl.TabIndex = 9;
            this.Tpopulation_lbl.Text = "00000";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(227, 417);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(122, 100);
            this.pieChart1.TabIndex = 13;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(227, 541);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(123, 100);
            this.pieChart2.TabIndex = 14;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart3
            // 
            this.pieChart3.Location = new System.Drawing.Point(467, 417);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(148, 100);
            this.pieChart3.TabIndex = 15;
            this.pieChart3.Text = "pieChart3";
            // 
            // summaries_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pieChart3);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Tpopulation_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchbox_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Residents);
            this.Name = "summaries_uc";
            this.Size = new System.Drawing.Size(872, 669);
            this.Load += new System.EventHandler(this.summaries_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Residents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox_tbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Button refresh_btn;
        public System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.DataGridView Residents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resident_ID;
        private System.Windows.Forms.DataGridViewImageColumn Profile_picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voter_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn marital_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_fam_mem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn educ_attainment;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_acc_occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacc_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tpopulation_lbl;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart3;
    }
}
