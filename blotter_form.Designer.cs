namespace WindowsFormsApp1
{
    partial class blotter_form
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
            this.com_name_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.blotter_cancel_btn = new System.Windows.Forms.Button();
            this.blotter_send_btn = new System.Windows.Forms.Button();
            this.narration_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.def_name_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_happened = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_name_tbx
            // 
            this.com_name_tbx.AcceptsTab = true;
            this.com_name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.com_name_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.com_name_tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.com_name_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_name_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.com_name_tbx.Location = new System.Drawing.Point(18, 104);
            this.com_name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.com_name_tbx.Name = "com_name_tbx";
            this.com_name_tbx.Size = new System.Drawing.Size(311, 18);
            this.com_name_tbx.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Complainant name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 112;
            this.label1.Text = "Write a blotter";
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Close_btn.Location = new System.Drawing.Point(312, 3);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(27, 23);
            this.Close_btn.TabIndex = 76;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // blotter_cancel_btn
            // 
            this.blotter_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.blotter_cancel_btn.FlatAppearance.BorderSize = 0;
            this.blotter_cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.blotter_cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.blotter_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blotter_cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blotter_cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.blotter_cancel_btn.Location = new System.Drawing.Point(247, 396);
            this.blotter_cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.blotter_cancel_btn.Name = "blotter_cancel_btn";
            this.blotter_cancel_btn.Size = new System.Drawing.Size(68, 31);
            this.blotter_cancel_btn.TabIndex = 111;
            this.blotter_cancel_btn.Text = "Clear";
            this.blotter_cancel_btn.UseVisualStyleBackColor = false;
            this.blotter_cancel_btn.Click += new System.EventHandler(this.blotter_cancel_btn_Click);
            // 
            // blotter_send_btn
            // 
            this.blotter_send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.blotter_send_btn.FlatAppearance.BorderSize = 0;
            this.blotter_send_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.blotter_send_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.blotter_send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blotter_send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blotter_send_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.blotter_send_btn.Location = new System.Drawing.Point(161, 396);
            this.blotter_send_btn.Margin = new System.Windows.Forms.Padding(2);
            this.blotter_send_btn.Name = "blotter_send_btn";
            this.blotter_send_btn.Size = new System.Drawing.Size(68, 31);
            this.blotter_send_btn.TabIndex = 110;
            this.blotter_send_btn.Text = "Send";
            this.blotter_send_btn.UseVisualStyleBackColor = false;
            this.blotter_send_btn.Click += new System.EventHandler(this.blotter_send_btn_Click);
            // 
            // narration_tbx
            // 
            this.narration_tbx.AcceptsTab = true;
            this.narration_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.narration_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.narration_tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.narration_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narration_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.narration_tbx.Location = new System.Drawing.Point(17, 237);
            this.narration_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.narration_tbx.Multiline = true;
            this.narration_tbx.Name = "narration_tbx";
            this.narration_tbx.Size = new System.Drawing.Size(312, 135);
            this.narration_tbx.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(14, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Narrate the incident:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label18.Location = new System.Drawing.Point(14, 170);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 17);
            this.label18.TabIndex = 115;
            this.label18.Text = "Date happened";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(342, 29);
            this.panel1.TabIndex = 114;
            // 
            // def_name_tbx
            // 
            this.def_name_tbx.AcceptsTab = true;
            this.def_name_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.def_name_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.def_name_tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.def_name_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_name_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.def_name_tbx.Location = new System.Drawing.Point(18, 147);
            this.def_name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.def_name_tbx.Name = "def_name_tbx";
            this.def_name_tbx.Size = new System.Drawing.Size(311, 18);
            this.def_name_tbx.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 118;
            this.label4.Text = "Defendant name:";
            // 
            // date_happened
            // 
            this.date_happened.CalendarFont = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_happened.CalendarForeColor = System.Drawing.Color.Black;
            this.date_happened.CalendarMonthBackground = System.Drawing.Color.Black;
            this.date_happened.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.date_happened.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.date_happened.CustomFormat = "yyyy-MM-dd";
            this.date_happened.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_happened.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_happened.Location = new System.Drawing.Point(18, 189);
            this.date_happened.Margin = new System.Windows.Forms.Padding(2);
            this.date_happened.Name = "date_happened";
            this.date_happened.Size = new System.Drawing.Size(139, 23);
            this.date_happened.TabIndex = 119;
            this.date_happened.Value = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            // 
            // blotter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.ControlBox = false;
            this.Controls.Add(this.date_happened);
            this.Controls.Add(this.def_name_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.com_name_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blotter_cancel_btn);
            this.Controls.Add(this.blotter_send_btn);
            this.Controls.Add(this.narration_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "blotter_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "blotter_form";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox com_name_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button blotter_cancel_btn;
        private System.Windows.Forms.Button blotter_send_btn;
        private System.Windows.Forms.TextBox narration_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox def_name_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_happened;
    }
}