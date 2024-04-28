namespace WindowsFormsApp1.employee_tabs_controls
{
    partial class blotter_logs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blotter_logs));
            this.blotter_searchbox_tbx = new System.Windows.Forms.TextBox();
            this.blotters = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.narration_lbl = new System.Windows.Forms.Label();
            this.defendant_name_lbl = new System.Windows.Forms.Label();
            this.date_happened_lbl = new System.Windows.Forms.Label();
            this.com_name_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.def_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_happ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.blotters)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // blotter_searchbox_tbx
            // 
            this.blotter_searchbox_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blotter_searchbox_tbx.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blotter_searchbox_tbx.ForeColor = System.Drawing.Color.DimGray;
            this.blotter_searchbox_tbx.Location = new System.Drawing.Point(63, 85);
            this.blotter_searchbox_tbx.Name = "blotter_searchbox_tbx";
            this.blotter_searchbox_tbx.Size = new System.Drawing.Size(233, 18);
            this.blotter_searchbox_tbx.TabIndex = 16;
            this.blotter_searchbox_tbx.Text = "search for a name...";
            this.blotter_searchbox_tbx.Click += new System.EventHandler(this.blotter_searchbox_tbx_Click);
            this.blotter_searchbox_tbx.TextChanged += new System.EventHandler(this.blotter_searchbox_tbx_TextChanged);
            // 
            // blotters
            // 
            this.blotters.BackgroundColor = System.Drawing.SystemColors.Window;
            this.blotters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blotters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.com_name,
            this.def_name,
            this.date_happ,
            this.narration});
            this.blotters.GridColor = System.Drawing.SystemColors.ControlLight;
            this.blotters.Location = new System.Drawing.Point(37, 120);
            this.blotters.MultiSelect = false;
            this.blotters.Name = "blotters";
            this.blotters.ReadOnly = true;
            this.blotters.Size = new System.Drawing.Size(458, 257);
            this.blotters.TabIndex = 15;
            this.blotters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blotters_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Document request log";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.narration_lbl);
            this.panel1.Controls.Add(this.defendant_name_lbl);
            this.panel1.Controls.Add(this.date_happened_lbl);
            this.panel1.Controls.Add(this.com_name_lbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(517, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 356);
            this.panel1.TabIndex = 12;
            // 
            // narration_lbl
            // 
            this.narration_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.narration_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narration_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.narration_lbl.Location = new System.Drawing.Point(20, 177);
            this.narration_lbl.Name = "narration_lbl";
            this.narration_lbl.Size = new System.Drawing.Size(276, 157);
            this.narration_lbl.TabIndex = 7;
            this.narration_lbl.Text = "narration";
            // 
            // defendant_name_lbl
            // 
            this.defendant_name_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.defendant_name_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendant_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.defendant_name_lbl.Location = new System.Drawing.Point(20, 99);
            this.defendant_name_lbl.Name = "defendant_name_lbl";
            this.defendant_name_lbl.Size = new System.Drawing.Size(276, 17);
            this.defendant_name_lbl.TabIndex = 7;
            this.defendant_name_lbl.Text = "defendant name";
            // 
            // date_happened_lbl
            // 
            this.date_happened_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_happened_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_happened_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.date_happened_lbl.Location = new System.Drawing.Point(20, 137);
            this.date_happened_lbl.Name = "date_happened_lbl";
            this.date_happened_lbl.Size = new System.Drawing.Size(276, 17);
            this.date_happened_lbl.TabIndex = 7;
            this.date_happened_lbl.Text = "yyyy-MM-dd";
            // 
            // com_name_lbl
            // 
            this.com_name_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_name_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.com_name_lbl.Location = new System.Drawing.Point(20, 59);
            this.com_name_lbl.Name = "com_name_lbl";
            this.com_name_lbl.Size = new System.Drawing.Size(276, 17);
            this.com_name_lbl.TabIndex = 7;
            this.com_name_lbl.Text = "complainant name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Incident report:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Defendant name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comaplainant name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "View request";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date happened:";
            // 
            // com_name
            // 
            this.com_name.Frozen = true;
            this.com_name.HeaderText = "Complainant name";
            this.com_name.Name = "com_name";
            this.com_name.ReadOnly = true;
            // 
            // def_name
            // 
            this.def_name.HeaderText = "Defendant name";
            this.def_name.Name = "def_name";
            this.def_name.ReadOnly = true;
            // 
            // date_happ
            // 
            this.date_happ.HeaderText = "Date happened";
            this.date_happ.Name = "date_happ";
            this.date_happ.ReadOnly = true;
            // 
            // narration
            // 
            this.narration.HeaderText = "Incident report";
            this.narration.Name = "narration";
            this.narration.ReadOnly = true;
            // 
            // blotter_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.blotter_searchbox_tbx);
            this.Controls.Add(this.blotters);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "blotter_logs";
            this.Size = new System.Drawing.Size(872, 399);
            this.Load += new System.EventHandler(this.blotter_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blotters)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox blotter_searchbox_tbx;
        public System.Windows.Forms.DataGridView blotters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label narration_lbl;
        private System.Windows.Forms.Label defendant_name_lbl;
        private System.Windows.Forms.Label date_happened_lbl;
        private System.Windows.Forms.Label com_name_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn def_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_happ;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
    }
}
