namespace GUI.Model
{
    partial class FFoodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFoodAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMon = new Guna.UI.WinForms.GunaTextBox();
            this.txtGia = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbHinh = new Guna.UI.WinForms.GunaPictureBox();
            this.txtLMA = new System.Windows.Forms.ComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Size = new System.Drawing.Size(189, 38);
            this.lbl1.Text = "Thêm món ăn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            // 
            // btnCLose
            // 
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên món";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BaseColor = System.Drawing.Color.White;
            this.txtTenMon.BorderColor = System.Drawing.Color.Silver;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenMon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenMon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(49, 195);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(160, 41);
            this.txtTenMon.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.BaseColor = System.Drawing.Color.White;
            this.txtGia.BorderColor = System.Drawing.Color.Silver;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(49, 275);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(160, 41);
            this.txtGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại món ăn";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(596, 315);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(107, 43);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Mở";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbHinh
            // 
            this.pbHinh.BaseColor = System.Drawing.Color.White;
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.Location = new System.Drawing.Point(584, 154);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(154, 141);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 10;
            this.pbHinh.TabStop = false;
            // 
            // txtLMA
            // 
            this.txtLMA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLMA.ForeColor = System.Drawing.Color.Black;
            this.txtLMA.FormattingEnabled = true;
            this.txtLMA.Location = new System.Drawing.Point(284, 197);
            this.txtLMA.Name = "txtLMA";
            this.txtLMA.Size = new System.Drawing.Size(189, 39);
            this.txtLMA.TabIndex = 11;
            // 
            // FFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLMA);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label1);
            this.Name = "FFoodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFoodAdd";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTenMon, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtGia, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.pbHinh, 0);
            this.Controls.SetChildIndex(this.txtLMA, 0);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtTenMon;
        public Guna.UI.WinForms.GunaTextBox txtGia;
        public Guna.UI.WinForms.GunaPictureBox pbHinh;
        public System.Windows.Forms.ComboBox txtLMA;
        public System.Windows.Forms.Button btnBrowse;
    }
}