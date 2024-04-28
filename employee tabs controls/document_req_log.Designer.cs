namespace WindowsFormsApp1.employee_tabs_controls
{
    partial class document_req_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(document_req_log));
            this.panel1 = new System.Windows.Forms.Panel();
            this.purpose_lbl = new System.Windows.Forms.Label();
            this.document_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.docu_req = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.doc_req_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document_request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docu_req)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.purpose_lbl);
            this.panel1.Controls.Add(this.document_lbl);
            this.panel1.Controls.Add(this.date_lbl);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(756, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 395);
            this.panel1.TabIndex = 1;
            // 
            // purpose_lbl
            // 
            this.purpose_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purpose_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.purpose_lbl.Location = new System.Drawing.Point(30, 283);
            this.purpose_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purpose_lbl.Name = "purpose_lbl";
            this.purpose_lbl.Size = new System.Drawing.Size(414, 89);
            this.purpose_lbl.TabIndex = 7;
            this.purpose_lbl.Text = "purpose";
            // 
            // document_lbl
            // 
            this.document_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.document_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.document_lbl.Location = new System.Drawing.Point(30, 220);
            this.document_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.document_lbl.Name = "document_lbl";
            this.document_lbl.Size = new System.Drawing.Size(414, 26);
            this.document_lbl.TabIndex = 7;
            this.document_lbl.Text = "document";
            // 
            // date_lbl
            // 
            this.date_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.date_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.date_lbl.Location = new System.Drawing.Point(30, 154);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(414, 26);
            this.date_lbl.TabIndex = 7;
            this.date_lbl.Text = "yyyy-MM-dd";
            // 
            // name_lbl
            // 
            this.name_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_lbl.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.name_lbl.Location = new System.Drawing.Point(30, 91);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(414, 26);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(30, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Purpose:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(30, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Document requested:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(30, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Document request log";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 120);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(75, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "search for a name...";
            this.textBox1.Click += new System.EventHandler(this.searchbox_tbx_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.searchbox_tbx_TextChanged);
            // 
            // docu_req
            // 
            this.docu_req.BackgroundColor = System.Drawing.SystemColors.Window;
            this.docu_req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docu_req.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doc_req_ID,
            this.full_name,
            this.Date,
            this.document_request,
            this.purpose});
            this.docu_req.GridColor = System.Drawing.SystemColors.ControlLight;
            this.docu_req.Location = new System.Drawing.Point(36, 178);
            this.docu_req.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.docu_req.MultiSelect = false;
            this.docu_req.Name = "docu_req";
            this.docu_req.ReadOnly = true;
            this.docu_req.RowHeadersWidth = 62;
            this.docu_req.Size = new System.Drawing.Size(687, 395);
            this.docu_req.TabIndex = 9;
            this.docu_req.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blotters_CellClick);
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
            this.delete_btn.Location = new System.Drawing.Point(606, 120);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(117, 38);
            this.delete_btn.TabIndex = 19;
            this.delete_btn.Text = "     Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // doc_req_ID
            // 
            this.doc_req_ID.HeaderText = "ID";
            this.doc_req_ID.MinimumWidth = 8;
            this.doc_req_ID.Name = "doc_req_ID";
            this.doc_req_ID.ReadOnly = true;
            this.doc_req_ID.Width = 150;
            // 
            // full_name
            // 
            this.full_name.HeaderText = "Full Name";
            this.full_name.MinimumWidth = 8;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // document_request
            // 
            this.document_request.HeaderText = "Document requested";
            this.document_request.MinimumWidth = 8;
            this.document_request.Name = "document_request";
            this.document_request.ReadOnly = true;
            this.document_request.Width = 150;
            // 
            // purpose
            // 
            this.purpose.HeaderText = "Purpose";
            this.purpose.MinimumWidth = 8;
            this.purpose.Name = "purpose";
            this.purpose.ReadOnly = true;
            this.purpose.Width = 150;
            // 
            // document_req_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.docu_req);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "document_req_log";
            this.Size = new System.Drawing.Size(1308, 614);
            this.Load += new System.EventHandler(this.blotter_log_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docu_req)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label purpose_lbl;
        private System.Windows.Forms.Label document_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView docu_req;
        public System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_req_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn document_request;
        private System.Windows.Forms.DataGridViewTextBoxColumn purpose;
    }
}
