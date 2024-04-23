namespace WindowsFormsApp1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.Password_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signin_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.hide_btn = new System.Windows.Forms.Button();
            this.opacitytimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // Name_tbx
            // 
            this.Name_tbx.AcceptsTab = true;
            this.Name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Name_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Name_tbx.Location = new System.Drawing.Point(39, 107);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(209, 19);
            this.Name_tbx.TabIndex = 0;
            this.Name_tbx.TextChanged += new System.EventHandler(this.Name_tbx_TextChanged);
            // 
            // Password_tbx
            // 
            this.Password_tbx.AcceptsTab = true;
            this.Password_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Password_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Password_tbx.Location = new System.Drawing.Point(39, 154);
            this.Password_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Password_tbx.Name = "Password_tbx";
            this.Password_tbx.PasswordChar = '*';
            this.Password_tbx.Size = new System.Drawing.Size(209, 19);
            this.Password_tbx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.signin_btn.Location = new System.Drawing.Point(64, 201);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(68, 31);
            this.signin_btn.TabIndex = 2;
            this.signin_btn.Text = "Sign in";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
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
            this.cancel_btn.Location = new System.Drawing.Point(151, 201);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(68, 31);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.show_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_btn.BackgroundImage")));
            this.show_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn.FlatAppearance.BorderSize = 0;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Location = new System.Drawing.Point(223, 154);
            this.show_btn.Margin = new System.Windows.Forms.Padding(2);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(23, 19);
            this.show_btn.TabIndex = 28;
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.hide_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_btn.BackgroundImage")));
            this.hide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_btn.FlatAppearance.BorderSize = 0;
            this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn.Location = new System.Drawing.Point(223, 154);
            this.hide_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(23, 19);
            this.hide_btn.TabIndex = 27;
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // opacitytimer
            // 
            this.opacitytimer.Enabled = true;
            this.opacitytimer.Interval = 10;
            this.opacitytimer.Tick += new System.EventHandler(this.animationtimer_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(289, 257);
            this.ControlBox = false;
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.Password_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "omment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Timer opacitytimer;
        public System.Windows.Forms.TextBox Name_tbx;
        public System.Windows.Forms.TextBox Password_tbx;
    }
}