namespace WindowsFormsApp1
{
    partial class signup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.Password_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstname_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastname_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.age_numselect = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Confirmpass_tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.hide_btn2 = new System.Windows.Forms.Button();
            this.hide_btn1 = new System.Windows.Forms.Button();
            this.show_btn2 = new System.Windows.Forms.Button();
            this.show_btn1 = new System.Windows.Forms.Button();
            this.animation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.age_numselect)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.cancel_btn.Location = new System.Drawing.Point(143, 394);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(68, 31);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Clear";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.signup_btn.Location = new System.Drawing.Point(56, 394);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(2);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(68, 31);
            this.signup_btn.TabIndex = 9;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signin_btn_Click);
            this.signup_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signin_btn_KeyDown);
            // 
            // Password_tbx
            // 
            this.Password_tbx.AcceptsTab = true;
            this.Password_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Password_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Password_tbx.Location = new System.Drawing.Point(33, 289);
            this.Password_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Password_tbx.Name = "Password_tbx";
            this.Password_tbx.PasswordChar = '*';
            this.Password_tbx.Size = new System.Drawing.Size(209, 19);
            this.Password_tbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(29, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // firstname_tbx
            // 
            this.firstname_tbx.AcceptsTab = true;
            this.firstname_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.firstname_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.firstname_tbx.Location = new System.Drawing.Point(33, 101);
            this.firstname_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.firstname_tbx.Name = "firstname_tbx";
            this.firstname_tbx.Size = new System.Drawing.Size(209, 19);
            this.firstname_tbx.TabIndex = 1;
            this.firstname_tbx.TextChanged += new System.EventHandler(this.firstname_tbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign up";
            // 
            // lastname_tbx
            // 
            this.lastname_tbx.AcceptsTab = true;
            this.lastname_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.lastname_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.lastname_tbx.Location = new System.Drawing.Point(33, 150);
            this.lastname_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.lastname_tbx.Name = "lastname_tbx";
            this.lastname_tbx.Size = new System.Drawing.Size(209, 19);
            this.lastname_tbx.TabIndex = 2;
            this.lastname_tbx.TextChanged += new System.EventHandler(this.lastname_tbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(29, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last name";
            // 
            // birthdate
            // 
            this.birthdate.CalendarFont = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.CalendarForeColor = System.Drawing.Color.Black;
            this.birthdate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.birthdate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.birthdate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.birthdate.CustomFormat = "yyyy-MM-dd";
            this.birthdate.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdate.Location = new System.Drawing.Point(33, 198);
            this.birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(139, 23);
            this.birthdate.TabIndex = 3;
            this.birthdate.Value = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label5.Location = new System.Drawing.Point(29, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birthdate";
            // 
            // age_numselect
            // 
            this.age_numselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.age_numselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_numselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.age_numselect.Location = new System.Drawing.Point(181, 197);
            this.age_numselect.Margin = new System.Windows.Forms.Padding(2);
            this.age_numselect.Name = "age_numselect";
            this.age_numselect.Size = new System.Drawing.Size(61, 24);
            this.age_numselect.TabIndex = 4;
            this.age_numselect.ValueChanged += new System.EventHandler(this.age_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label6.Location = new System.Drawing.Point(177, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Age";
            // 
            // sex
            // 
            this.sex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.sex.Location = new System.Drawing.Point(33, 244);
            this.sex.Margin = new System.Windows.Forms.Padding(2);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(64, 21);
            this.sex.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label7.Location = new System.Drawing.Point(29, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sex";
            // 
            // Confirmpass_tbx
            // 
            this.Confirmpass_tbx.AcceptsTab = true;
            this.Confirmpass_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Confirmpass_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Confirmpass_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpass_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Confirmpass_tbx.Location = new System.Drawing.Point(33, 339);
            this.Confirmpass_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Confirmpass_tbx.Name = "Confirmpass_tbx";
            this.Confirmpass_tbx.PasswordChar = '*';
            this.Confirmpass_tbx.Size = new System.Drawing.Size(209, 19);
            this.Confirmpass_tbx.TabIndex = 7;
            this.Confirmpass_tbx.TextChanged += new System.EventHandler(this.Confirmpass_tbx_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label8.Location = new System.Drawing.Point(29, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Confirm Password";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.exit_btn.Location = new System.Drawing.Point(247, 6);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(21, 23);
            this.exit_btn.TabIndex = 22;
            this.exit_btn.Text = "X\r\n";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // hide_btn2
            // 
            this.hide_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.hide_btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_btn2.BackgroundImage")));
            this.hide_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_btn2.FlatAppearance.BorderSize = 0;
            this.hide_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn2.Location = new System.Drawing.Point(215, 339);
            this.hide_btn2.Margin = new System.Windows.Forms.Padding(2);
            this.hide_btn2.Name = "hide_btn2";
            this.hide_btn2.Size = new System.Drawing.Size(23, 19);
            this.hide_btn2.TabIndex = 25;
            this.hide_btn2.UseVisualStyleBackColor = false;
            this.hide_btn2.Click += new System.EventHandler(this.hide_btn2_Click);
            // 
            // hide_btn1
            // 
            this.hide_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.hide_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_btn1.BackgroundImage")));
            this.hide_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_btn1.FlatAppearance.BorderSize = 0;
            this.hide_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn1.Location = new System.Drawing.Point(215, 289);
            this.hide_btn1.Margin = new System.Windows.Forms.Padding(2);
            this.hide_btn1.Name = "hide_btn1";
            this.hide_btn1.Size = new System.Drawing.Size(23, 19);
            this.hide_btn1.TabIndex = 27;
            this.hide_btn1.UseVisualStyleBackColor = false;
            this.hide_btn1.Click += new System.EventHandler(this.hide_btn1_Click);
            // 
            // show_btn2
            // 
            this.show_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.show_btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_btn2.BackgroundImage")));
            this.show_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn2.FlatAppearance.BorderSize = 0;
            this.show_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn2.Location = new System.Drawing.Point(215, 339);
            this.show_btn2.Margin = new System.Windows.Forms.Padding(2);
            this.show_btn2.Name = "show_btn2";
            this.show_btn2.Size = new System.Drawing.Size(23, 19);
            this.show_btn2.TabIndex = 26;
            this.show_btn2.UseVisualStyleBackColor = false;
            this.show_btn2.Click += new System.EventHandler(this.show_btn2_Click);
            // 
            // show_btn1
            // 
            this.show_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.show_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_btn1.BackgroundImage")));
            this.show_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn1.FlatAppearance.BorderSize = 0;
            this.show_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn1.Location = new System.Drawing.Point(215, 289);
            this.show_btn1.Margin = new System.Windows.Forms.Padding(2);
            this.show_btn1.Name = "show_btn1";
            this.show_btn1.Size = new System.Drawing.Size(23, 19);
            this.show_btn1.TabIndex = 28;
            this.show_btn1.UseVisualStyleBackColor = false;
            this.show_btn1.Click += new System.EventHandler(this.button4_Click);
            // 
            // animation
            // 
            this.animation.Enabled = true;
            this.animation.Interval = 10;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(275, 457);
            this.Controls.Add(this.show_btn1);
            this.Controls.Add(this.hide_btn1);
            this.Controls.Add(this.show_btn2);
            this.Controls.Add(this.hide_btn2);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Confirmpass_tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age_numselect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.lastname_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.Password_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signup";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.age_numselect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox Password_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstname_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown age_numselect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Confirmpass_tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button hide_btn2;
        private System.Windows.Forms.Button hide_btn1;
        private System.Windows.Forms.Button show_btn2;
        private System.Windows.Forms.Button show_btn1;
        private System.Windows.Forms.Timer animation;
    }
}