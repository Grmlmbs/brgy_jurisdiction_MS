namespace WindowsFormsApp1
{
    partial class employee_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_login));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.signin_btn = new System.Windows.Forms.Button();
            this.empPassword_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empName_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empID_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.hide_btn = new System.Windows.Forms.Button();
            this.animation = new System.Windows.Forms.Timer(this.components);
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
            this.cancel_btn.Location = new System.Drawing.Point(146, 235);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(68, 31);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
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
            this.signin_btn.Location = new System.Drawing.Point(59, 235);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(68, 31);
            this.signin_btn.TabIndex = 3;
            this.signin_btn.Text = "Sign in";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // empPassword_tbx
            // 
            this.empPassword_tbx.AcceptsTab = true;
            this.empPassword_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.empPassword_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empPassword_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPassword_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.empPassword_tbx.Location = new System.Drawing.Point(33, 190);
            this.empPassword_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.empPassword_tbx.Name = "empPassword_tbx";
            this.empPassword_tbx.PasswordChar = '*';
            this.empPassword_tbx.Size = new System.Drawing.Size(209, 19);
            this.empPassword_tbx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // empName_tbx
            // 
            this.empName_tbx.AcceptsTab = true;
            this.empName_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.empName_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empName_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.empName_tbx.Location = new System.Drawing.Point(34, 90);
            this.empName_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.empName_tbx.Name = "empName_tbx";
            this.empName_tbx.Size = new System.Drawing.Size(209, 19);
            this.empName_tbx.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign in";
            // 
            // empID_tbx
            // 
            this.empID_tbx.AcceptsTab = true;
            this.empID_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.empID_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empID_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.empID_tbx.Location = new System.Drawing.Point(34, 139);
            this.empID_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.empID_tbx.Name = "empID_tbx";
            this.empID_tbx.Size = new System.Drawing.Size(209, 19);
            this.empID_tbx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(31, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee ID";
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.show_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_btn.BackgroundImage")));
            this.show_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn.FlatAppearance.BorderSize = 0;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Location = new System.Drawing.Point(217, 191);
            this.show_btn.Margin = new System.Windows.Forms.Padding(2);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(23, 18);
            this.show_btn.TabIndex = 28;
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.hide_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_btn.BackgroundImage")));
            this.hide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_btn.FlatAppearance.BorderSize = 0;
            this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn.Location = new System.Drawing.Point(217, 191);
            this.hide_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(23, 18);
            this.hide_btn.TabIndex = 27;
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // animation
            // 
            this.animation.Enabled = true;
            this.animation.Interval = 10;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // employee_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(274, 296);
            this.ControlBox = false;
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.empID_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.empPassword_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empName_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "employee_login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employee_login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.TextBox empPassword_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empName_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empID_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Timer animation;
    }
}