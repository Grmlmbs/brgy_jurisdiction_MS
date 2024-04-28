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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.blotter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.blotter_searchbox_tbx.Location = new System.Drawing.Point(94, 131);
            this.blotter_searchbox_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blotter_searchbox_tbx.Name = "blotter_searchbox_tbx";
            this.blotter_searchbox_tbx.Size = new System.Drawing.Size(350, 26);
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
            this.blotter_ID,
            this.com_name,
            this.def_name,
            this.date_happ,
            this.narration});
            this.blotters.GridColor = System.Drawing.SystemColors.ControlLight;
            this.blotters.Location = new System.Drawing.Point(56, 185);
            this.blotters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blotters.MultiSelect = false;
            this.blotters.Name = "blotters";
            this.blotters.ReadOnly = true;
            this.blotters.RowHeadersWidth = 62;
            this.blotters.Size = new System.Drawing.Size(687, 395);
            this.blotters.TabIndex = 15;
            this.blotters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blotters_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(134, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Blotter log";
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
            this.panel1.Location = new System.Drawing.Point(776, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 548);
            this.panel1.TabIndex = 12;
            // 
            // narration_lbl
            // 
            this.narration_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.narration_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narration_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.narration_lbl.Location = new System.Drawing.Point(30, 272);
            this.narration_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.narration_lbl.Name = "narration_lbl";
            this.narration_lbl.Size = new System.Drawing.Size(414, 242);
            this.narration_lbl.TabIndex = 7;
            this.narration_lbl.Text = "narration";
            // 
            // defendant_name_lbl
            // 
            this.defendant_name_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.defendant_name_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendant_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.defendant_name_lbl.Location = new System.Drawing.Point(30, 152);
            this.defendant_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defendant_name_lbl.Name = "defendant_name_lbl";
            this.defendant_name_lbl.Size = new System.Drawing.Size(414, 26);
            this.defendant_name_lbl.TabIndex = 7;
            this.defendant_name_lbl.Text = "defendant name";
            // 
            // date_happened_lbl
            // 
            this.date_happened_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_happened_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_happened_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.date_happened_lbl.Location = new System.Drawing.Point(30, 211);
            this.date_happened_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_happened_lbl.Name = "date_happened_lbl";
            this.date_happened_lbl.Size = new System.Drawing.Size(414, 26);
            this.date_happened_lbl.TabIndex = 7;
            this.date_happened_lbl.Text = "yyyy-MM-dd";
            // 
            // com_name_lbl
            // 
            this.com_name_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_name_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.com_name_lbl.Location = new System.Drawing.Point(30, 91);
            this.com_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.com_name_lbl.Name = "com_name_lbl";
            this.com_name_lbl.Size = new System.Drawing.Size(414, 26);
            this.com_name_lbl.TabIndex = 7;
            this.com_name_lbl.Text = "complainant name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(30, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Incident report:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(30, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Defendant name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(30, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date happened:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(30, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comaplainant name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(154, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "View request";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(56, 126);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.delete_btn.Location = new System.Drawing.Point(626, 126);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(117, 38);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "     Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // blotter_ID
            // 
            this.blotter_ID.HeaderText = "Blotter ID";
            this.blotter_ID.MinimumWidth = 8;
            this.blotter_ID.Name = "blotter_ID";
            this.blotter_ID.ReadOnly = true;
            this.blotter_ID.Width = 150;
            // 
            // com_name
            // 
            this.com_name.HeaderText = "Complainant name";
            this.com_name.MinimumWidth = 8;
            this.com_name.Name = "com_name";
            this.com_name.ReadOnly = true;
            this.com_name.Width = 150;
            // 
            // def_name
            // 
            this.def_name.HeaderText = "Defendant name";
            this.def_name.MinimumWidth = 8;
            this.def_name.Name = "def_name";
            this.def_name.ReadOnly = true;
            this.def_name.Width = 150;
            // 
            // date_happ
            // 
            this.date_happ.HeaderText = "Date happened";
            this.date_happ.MinimumWidth = 8;
            this.date_happ.Name = "date_happ";
            this.date_happ.ReadOnly = true;
            this.date_happ.Width = 150;
            // 
            // narration
            // 
            this.narration.HeaderText = "Incident report";
            this.narration.MinimumWidth = 8;
            this.narration.Name = "narration";
            this.narration.ReadOnly = true;
            this.narration.Width = 150;
            // 
            // blotter_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.blotter_searchbox_tbx);
            this.Controls.Add(this.blotters);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "blotter_logs";
            this.Size = new System.Drawing.Size(1308, 614);
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
        public System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blotter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn def_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_happ;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
    }
}
