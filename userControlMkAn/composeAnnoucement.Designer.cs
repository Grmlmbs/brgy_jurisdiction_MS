namespace WindowsFormsApp1.userControlMkAn
{
    partial class composeAnnoucement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(composeAnnoucement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eve_when_from_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.eve_how_tbx = new System.Windows.Forms.TextBox();
            this.post_btn = new System.Windows.Forms.Button();
            this.eve_what_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eve_who_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eve_where_tbx = new System.Windows.Forms.TextBox();
            this.eve_why_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.event_initial_pbx = new System.Windows.Forms.PictureBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.event_Image_pbx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event_initial_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_Image_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 393);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.eve_when_from_dtp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.eve_how_tbx);
            this.panel3.Controls.Add(this.post_btn);
            this.panel3.Controls.Add(this.eve_what_tbx);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.eve_who_tbx);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.eve_where_tbx);
            this.panel3.Controls.Add(this.eve_why_tbx);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(316, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 393);
            this.panel3.TabIndex = 1;
            // 
            // eve_when_from_dtp
            // 
            this.eve_when_from_dtp.CalendarFont = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_when_from_dtp.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.eve_when_from_dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.eve_when_from_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eve_when_from_dtp.Location = new System.Drawing.Point(357, 70);
            this.eve_when_from_dtp.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.eve_when_from_dtp.Name = "eve_when_from_dtp";
            this.eve_when_from_dtp.Size = new System.Drawing.Size(164, 20);
            this.eve_when_from_dtp.TabIndex = 53;
            this.eve_when_from_dtp.Value = new System.DateTime(2024, 4, 21, 0, 0, 0, 0);
            this.eve_when_from_dtp.ValueChanged += new System.EventHandler(this.eve_when_from_dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "WHAT?";
            // 
            // eve_how_tbx
            // 
            this.eve_how_tbx.BackColor = System.Drawing.Color.LightCyan;
            this.eve_how_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eve_how_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_how_tbx.Location = new System.Drawing.Point(38, 266);
            this.eve_how_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.eve_how_tbx.Multiline = true;
            this.eve_how_tbx.Name = "eve_how_tbx";
            this.eve_how_tbx.Size = new System.Drawing.Size(483, 72);
            this.eve_how_tbx.TabIndex = 52;
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.post_btn.FlatAppearance.BorderSize = 0;
            this.post_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.post_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.post_btn.Location = new System.Drawing.Point(231, 352);
            this.post_btn.Margin = new System.Windows.Forms.Padding(2);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(143, 29);
            this.post_btn.TabIndex = 41;
            this.post_btn.Text = "POST";
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click_1);
            // 
            // eve_what_tbx
            // 
            this.eve_what_tbx.BackColor = System.Drawing.Color.LightCyan;
            this.eve_what_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eve_what_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_what_tbx.Location = new System.Drawing.Point(38, 30);
            this.eve_what_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.eve_what_tbx.Name = "eve_what_tbx";
            this.eve_what_tbx.Size = new System.Drawing.Size(484, 18);
            this.eve_what_tbx.TabIndex = 42;
            this.eve_what_tbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label6.Location = new System.Drawing.Point(34, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "HOW?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(353, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "WHEN?";
            // 
            // eve_who_tbx
            // 
            this.eve_who_tbx.BackColor = System.Drawing.Color.LightCyan;
            this.eve_who_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eve_who_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_who_tbx.Location = new System.Drawing.Point(38, 71);
            this.eve_who_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.eve_who_tbx.Name = "eve_who_tbx";
            this.eve_who_tbx.Size = new System.Drawing.Size(302, 18);
            this.eve_who_tbx.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label5.Location = new System.Drawing.Point(34, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "WHO?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "WHY?";
            // 
            // eve_where_tbx
            // 
            this.eve_where_tbx.BackColor = System.Drawing.Color.LightCyan;
            this.eve_where_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eve_where_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_where_tbx.Location = new System.Drawing.Point(38, 112);
            this.eve_where_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.eve_where_tbx.Multiline = true;
            this.eve_where_tbx.Name = "eve_where_tbx";
            this.eve_where_tbx.Size = new System.Drawing.Size(483, 36);
            this.eve_where_tbx.TabIndex = 48;
            // 
            // eve_why_tbx
            // 
            this.eve_why_tbx.BackColor = System.Drawing.Color.LightCyan;
            this.eve_why_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eve_why_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eve_why_tbx.Location = new System.Drawing.Point(38, 171);
            this.eve_why_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.eve_why_tbx.Multiline = true;
            this.eve_why_tbx.Name = "eve_why_tbx";
            this.eve_why_tbx.Size = new System.Drawing.Size(483, 72);
            this.eve_why_tbx.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(34, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "WHERE?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.event_initial_pbx);
            this.panel2.Controls.Add(this.upload_btn);
            this.panel2.Controls.Add(this.event_Image_pbx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 393);
            this.panel2.TabIndex = 0;
            // 
            // event_initial_pbx
            // 
            this.event_initial_pbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.event_initial_pbx.Image = ((System.Drawing.Image)(resources.GetObject("event_initial_pbx.Image")));
            this.event_initial_pbx.Location = new System.Drawing.Point(94, 91);
            this.event_initial_pbx.Name = "event_initial_pbx";
            this.event_initial_pbx.Size = new System.Drawing.Size(120, 122);
            this.event_initial_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.event_initial_pbx.TabIndex = 43;
            this.event_initial_pbx.TabStop = false;
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.upload_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload_btn.BackgroundImage")));
            this.upload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upload_btn.FlatAppearance.BorderSize = 0;
            this.upload_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_btn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.upload_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.upload_btn.Location = new System.Drawing.Point(113, 340);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(91, 31);
            this.upload_btn.TabIndex = 42;
            this.upload_btn.Text = "+   Upload";
            this.upload_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // event_Image_pbx
            // 
            this.event_Image_pbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.event_Image_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.event_Image_pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.event_Image_pbx.InitialImage = null;
            this.event_Image_pbx.Location = new System.Drawing.Point(10, 10);
            this.event_Image_pbx.Margin = new System.Windows.Forms.Padding(10);
            this.event_Image_pbx.Name = "event_Image_pbx";
            this.event_Image_pbx.Size = new System.Drawing.Size(293, 302);
            this.event_Image_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.event_Image_pbx.TabIndex = 28;
            this.event_Image_pbx.TabStop = false;
            // 
            // composeAnnoucement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "composeAnnoucement";
            this.Size = new System.Drawing.Size(878, 399);
            this.Load += new System.EventHandler(this.composeAnnoucement_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.event_initial_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_Image_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eve_how_tbx;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.TextBox eve_what_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eve_who_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eve_where_tbx;
        private System.Windows.Forms.TextBox eve_why_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.PictureBox event_Image_pbx;
        private System.Windows.Forms.DateTimePicker eve_when_from_dtp;
        private System.Windows.Forms.PictureBox event_initial_pbx;
    }
}
