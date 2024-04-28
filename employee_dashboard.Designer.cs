namespace WindowsFormsApp1
{
    partial class empDashboard
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
            this.logOut_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.abt_account_btn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.makeAnsmnt_btn = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.accPanel = new System.Windows.Forms.Panel();
            this.accounttabexpand = new System.Windows.Forms.Timer(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.docReq_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Blotters = new System.Windows.Forms.Panel();
            this.Blotter_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Summaries = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.posted_eve_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientPanel1 = new WindowsFormsApp1.GradientPanel();
            this.accName_btn = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.container.SuspendLayout();
            this.accPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Blotters.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut_btn
            // 
            this.logOut_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.logOut_btn.FlatAppearance.BorderSize = 0;
            this.logOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.logOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.logOut_btn.Location = new System.Drawing.Point(35, 160);
            this.logOut_btn.Margin = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(125, 25);
            this.logOut_btn.TabIndex = 0;
            this.logOut_btn.Text = "Log out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.abt_account_btn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 50);
            this.panel6.TabIndex = 3;
            // 
            // abt_account_btn
            // 
            this.abt_account_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.abt_account_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abt_account_btn.FlatAppearance.BorderSize = 0;
            this.abt_account_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.abt_account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abt_account_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abt_account_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.abt_account_btn.Location = new System.Drawing.Point(0, 0);
            this.abt_account_btn.Margin = new System.Windows.Forms.Padding(0);
            this.abt_account_btn.Name = "abt_account_btn";
            this.abt_account_btn.Size = new System.Drawing.Size(200, 50);
            this.abt_account_btn.TabIndex = 0;
            this.abt_account_btn.Text = "About acount";
            this.abt_account_btn.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.makeAnsmnt_btn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 100);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 50);
            this.panel8.TabIndex = 3;
            // 
            // makeAnsmnt_btn
            // 
            this.makeAnsmnt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.makeAnsmnt_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeAnsmnt_btn.FlatAppearance.BorderSize = 0;
            this.makeAnsmnt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.makeAnsmnt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAnsmnt_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAnsmnt_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.makeAnsmnt_btn.Location = new System.Drawing.Point(0, 0);
            this.makeAnsmnt_btn.Margin = new System.Windows.Forms.Padding(0);
            this.makeAnsmnt_btn.Name = "makeAnsmnt_btn";
            this.makeAnsmnt_btn.Size = new System.Drawing.Size(200, 50);
            this.makeAnsmnt_btn.TabIndex = 0;
            this.makeAnsmnt_btn.Text = "Make Announcement";
            this.makeAnsmnt_btn.UseVisualStyleBackColor = false;
            this.makeAnsmnt_btn.Click += new System.EventHandler(this.makeAnsmnt_btn_Click);
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.container.Controls.Add(this.accPanel);
            this.container.Controls.Add(this.panel6);
            this.container.Controls.Add(this.panel8);
            this.container.Controls.Add(this.logOut_btn);
            this.container.Location = new System.Drawing.Point(680, 26);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(200, 50);
            this.container.TabIndex = 2;
            // 
            // accPanel
            // 
            this.accPanel.Controls.Add(this.accName_btn);
            this.accPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accPanel.Location = new System.Drawing.Point(0, 0);
            this.accPanel.Margin = new System.Windows.Forms.Padding(0);
            this.accPanel.Name = "accPanel";
            this.accPanel.Size = new System.Drawing.Size(200, 50);
            this.accPanel.TabIndex = 0;
            // 
            // accounttabexpand
            // 
            this.accounttabexpand.Enabled = true;
            this.accounttabexpand.Interval = 10;
            this.accounttabexpand.Tick += new System.EventHandler(this.accounttabexpand_Tick);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // docReq_btn
            // 
            this.docReq_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.docReq_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docReq_btn.FlatAppearance.BorderSize = 0;
            this.docReq_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.docReq_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docReq_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docReq_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.docReq_btn.Location = new System.Drawing.Point(0, 0);
            this.docReq_btn.Margin = new System.Windows.Forms.Padding(0);
            this.docReq_btn.Name = "docReq_btn";
            this.docReq_btn.Size = new System.Drawing.Size(170, 50);
            this.docReq_btn.TabIndex = 3;
            this.docReq_btn.Text = "Document Request log";
            this.docReq_btn.UseVisualStyleBackColor = false;
            this.docReq_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Blotters);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 50);
            this.panel2.TabIndex = 3;
            // 
            // Blotters
            // 
            this.Blotters.Controls.Add(this.Blotter_btn);
            this.Blotters.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Blotters.Dock = System.Windows.Forms.DockStyle.Left;
            this.Blotters.Location = new System.Drawing.Point(510, 0);
            this.Blotters.Margin = new System.Windows.Forms.Padding(0);
            this.Blotters.Name = "Blotters";
            this.Blotters.Size = new System.Drawing.Size(170, 50);
            this.Blotters.TabIndex = 7;
            // 
            // Blotter_btn
            // 
            this.Blotter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Blotter_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Blotter_btn.FlatAppearance.BorderSize = 0;
            this.Blotter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Blotter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blotter_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blotter_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Blotter_btn.Location = new System.Drawing.Point(0, 0);
            this.Blotter_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Blotter_btn.Name = "Blotter_btn";
            this.Blotter_btn.Size = new System.Drawing.Size(170, 50);
            this.Blotter_btn.TabIndex = 3;
            this.Blotter_btn.Text = "Blotters";
            this.Blotter_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.docReq_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(340, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Summaries);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(170, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 50);
            this.panel4.TabIndex = 6;
            // 
            // Summaries
            // 
            this.Summaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Summaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Summaries.FlatAppearance.BorderSize = 0;
            this.Summaries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.Summaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Summaries.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Summaries.Location = new System.Drawing.Point(0, 0);
            this.Summaries.Margin = new System.Windows.Forms.Padding(0);
            this.Summaries.Name = "Summaries";
            this.Summaries.Size = new System.Drawing.Size(170, 50);
            this.Summaries.TabIndex = 3;
            this.Summaries.Text = "Summaries";
            this.Summaries.UseVisualStyleBackColor = false;
            this.Summaries.Click += new System.EventHandler(this.Summaries_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.posted_eve_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 50);
            this.panel3.TabIndex = 5;
            // 
            // posted_eve_btn
            // 
            this.posted_eve_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.posted_eve_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posted_eve_btn.FlatAppearance.BorderSize = 0;
            this.posted_eve_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.posted_eve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posted_eve_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posted_eve_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.posted_eve_btn.Location = new System.Drawing.Point(0, 0);
            this.posted_eve_btn.Margin = new System.Windows.Forms.Padding(0);
            this.posted_eve_btn.Name = "posted_eve_btn";
            this.posted_eve_btn.Size = new System.Drawing.Size(170, 50);
            this.posted_eve_btn.TabIndex = 3;
            this.posted_eve_btn.Text = "Events";
            this.posted_eve_btn.UseVisualStyleBackColor = false;
            this.posted_eve_btn.Click += new System.EventHandler(this.posted_eve_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(872, 398);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(878, 26);
            this.gradientPanel1.TabIndex = 5;
            // 
            // accName_btn
            // 
            this.accName_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.accName_btn.FlatAppearance.BorderSize = 0;
            this.accName_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.accName_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accName_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accName_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.accName_btn.Location = new System.Drawing.Point(0, 0);
            this.accName_btn.Margin = new System.Windows.Forms.Padding(0);
            this.accName_btn.Name = "accName_btn";
            this.accName_btn.Size = new System.Drawing.Size(200, 50);
            this.accName_btn.TabIndex = 0;
            this.accName_btn.Text = "Account Name";
            this.accName_btn.UseVisualStyleBackColor = false;
            this.accName_btn.Click += new System.EventHandler(this.accName_btn_Click);
            // 
            // empDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 475);
            this.Controls.Add(this.container);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "empDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee\'s Dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.accPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Blotters.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button makeAnsmnt_btn;
        private System.Windows.Forms.Button abt_account_btn;
        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Panel accPanel;
        private System.Windows.Forms.Timer accounttabexpand;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button docReq_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Blotters;
        private System.Windows.Forms.Button Blotter_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Summaries;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button posted_eve_btn;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button accName_btn;
    }
}