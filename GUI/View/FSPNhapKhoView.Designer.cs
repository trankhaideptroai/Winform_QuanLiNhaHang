namespace GUI.View
{
    partial class FSPNhapKhoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSPNhapKhoView));
            this.dgvSPNK = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvmaloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNK)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Size = new System.Drawing.Size(377, 54);
            this.label1.Text = "Sản phẩm nhập kho";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // dgvSPNK
            // 
            this.dgvSPNK.AllowUserToAddRows = false;
            this.dgvSPNK.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSPNK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSPNK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSPNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPNK.BackgroundColor = System.Drawing.Color.White;
            this.dgvSPNK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSPNK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSPNK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSPNK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSPNK.ColumnHeadersHeight = 40;
            this.dgvSPNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmaloai,
            this.dgvtensp,
            this.dgvsoluong,
            this.dgvngaynhap,
            this.dgvhsd,
            this.dgvncc,
            this.dgvidnv,
            this.dgvemail,
            this.dgvedit,
            this.dgvdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSPNK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSPNK.EnableHeadersVisualStyles = false;
            this.dgvSPNK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSPNK.Location = new System.Drawing.Point(87, 201);
            this.dgvSPNK.Name = "dgvSPNK";
            this.dgvSPNK.ReadOnly = true;
            this.dgvSPNK.RowHeadersVisible = false;
            this.dgvSPNK.RowHeadersWidth = 51;
            this.dgvSPNK.RowTemplate.Height = 24;
            this.dgvSPNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSPNK.Size = new System.Drawing.Size(887, 315);
            this.dgvSPNK.TabIndex = 6;
            this.dgvSPNK.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvSPNK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSPNK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSPNK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSPNK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSPNK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSPNK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSPNK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSPNK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSPNK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSPNK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dgvSPNK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSPNK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSPNK.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSPNK.ThemeStyle.ReadOnly = true;
            this.dgvSPNK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSPNK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSPNK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dgvSPNK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSPNK.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSPNK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSPNK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSPNK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSPNK_CellClick);
            // 
            // dgvmaloai
            // 
            this.dgvmaloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvmaloai.HeaderText = "Mã loại";
            this.dgvmaloai.MinimumWidth = 70;
            this.dgvmaloai.Name = "dgvmaloai";
            this.dgvmaloai.ReadOnly = true;
            this.dgvmaloai.Width = 125;
            // 
            // dgvtensp
            // 
            this.dgvtensp.HeaderText = "Tên sp";
            this.dgvtensp.MinimumWidth = 6;
            this.dgvtensp.Name = "dgvtensp";
            this.dgvtensp.ReadOnly = true;
            // 
            // dgvsoluong
            // 
            this.dgvsoluong.HeaderText = "Số lượng";
            this.dgvsoluong.MinimumWidth = 6;
            this.dgvsoluong.Name = "dgvsoluong";
            this.dgvsoluong.ReadOnly = true;
            // 
            // dgvngaynhap
            // 
            this.dgvngaynhap.HeaderText = "Ngày nhập";
            this.dgvngaynhap.MinimumWidth = 6;
            this.dgvngaynhap.Name = "dgvngaynhap";
            this.dgvngaynhap.ReadOnly = true;
            // 
            // dgvhsd
            // 
            this.dgvhsd.HeaderText = "Hsd";
            this.dgvhsd.MinimumWidth = 6;
            this.dgvhsd.Name = "dgvhsd";
            this.dgvhsd.ReadOnly = true;
            // 
            // dgvncc
            // 
            this.dgvncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvncc.HeaderText = "Nhà cung cấp";
            this.dgvncc.MinimumWidth = 6;
            this.dgvncc.Name = "dgvncc";
            this.dgvncc.ReadOnly = true;
            this.dgvncc.Width = 150;
            // 
            // dgvidnv
            // 
            this.dgvidnv.HeaderText = "IdNV";
            this.dgvidnv.MinimumWidth = 6;
            this.dgvidnv.Name = "dgvidnv";
            this.dgvidnv.ReadOnly = true;
            // 
            // dgvemail
            // 
            this.dgvemail.HeaderText = "Email";
            this.dgvemail.MinimumWidth = 6;
            this.dgvemail.Name = "dgvemail";
            this.dgvemail.ReadOnly = true;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = ((System.Drawing.Image)(resources.GetObject("dgvedit.Image")));
            this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvedit.MinimumWidth = 50;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = ((System.Drawing.Image)(resources.GetObject("dgvdel.Image")));
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // FSPNhapKhoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 565);
            this.Controls.Add(this.dgvSPNK);
            this.Name = "FSPNhapKhoView";
            this.Text = "FSPNhapKhoView";
            this.Load += new System.EventHandler(this.FSPNhapKhoView_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTimKiem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gunaSeparator1, 0);
            this.Controls.SetChildIndex(this.dgvSPNK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvSPNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmaloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}