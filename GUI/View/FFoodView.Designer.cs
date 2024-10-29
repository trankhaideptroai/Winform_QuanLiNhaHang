namespace GUI.View
{
    partial class FFoodView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFoodView));
            this.dgvFood = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvlma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidlma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgveditanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Size = new System.Drawing.Size(351, 54);
            this.label1.Text = "Danh sách món ăn";
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
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.ColumnHeadersHeight = 40;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvtenmon,
            this.dgvgia,
            this.dgvlma,
            this.dgvidlma,
            this.dgvhinh,
            this.dgvedit,
            this.dgveditanh,
            this.dgvdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFood.EnableHeadersVisualStyles = false;
            this.dgvFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.Location = new System.Drawing.Point(87, 201);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(887, 315);
            this.dgvFood.TabIndex = 6;
            this.dgvFood.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFood.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFood.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dgvFood.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFood.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvFood.ThemeStyle.ReadOnly = true;
            this.dgvFood.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFood.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dgvFood.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFood.ThemeStyle.RowsStyle.Height = 24;
            this.dgvFood.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvid.HeaderText = "ID Món";
            this.dgvid.MinimumWidth = 70;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 125;
            // 
            // dgvtenmon
            // 
            this.dgvtenmon.HeaderText = "Tên món";
            this.dgvtenmon.MinimumWidth = 6;
            this.dgvtenmon.Name = "dgvtenmon";
            this.dgvtenmon.ReadOnly = true;
            // 
            // dgvgia
            // 
            this.dgvgia.HeaderText = "Giá";
            this.dgvgia.MinimumWidth = 6;
            this.dgvgia.Name = "dgvgia";
            this.dgvgia.ReadOnly = true;
            // 
            // dgvlma
            // 
            this.dgvlma.HeaderText = "Loại món ăn";
            this.dgvlma.MinimumWidth = 6;
            this.dgvlma.Name = "dgvlma";
            this.dgvlma.ReadOnly = true;
            // 
            // dgvidlma
            // 
            this.dgvidlma.HeaderText = "Id LMA";
            this.dgvidlma.MinimumWidth = 6;
            this.dgvidlma.Name = "dgvidlma";
            this.dgvidlma.ReadOnly = true;
            // 
            // dgvhinh
            // 
            this.dgvhinh.HeaderText = "Hình";
            this.dgvhinh.MinimumWidth = 6;
            this.dgvhinh.Name = "dgvhinh";
            this.dgvhinh.ReadOnly = true;
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
            // dgveditanh
            // 
            this.dgveditanh.FillWeight = 50F;
            this.dgveditanh.HeaderText = "";
            this.dgveditanh.Image = ((System.Drawing.Image)(resources.GetObject("dgveditanh.Image")));
            this.dgveditanh.MinimumWidth = 50;
            this.dgveditanh.Name = "dgveditanh";
            this.dgveditanh.ReadOnly = true;
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
            // FFoodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 565);
            this.Controls.Add(this.dgvFood);
            this.Name = "FFoodView";
            this.Text = "FFoodView";
            this.Load += new System.EventHandler(this.FFoodView_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTimKiem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gunaSeparator1, 0);
            this.Controls.SetChildIndex(this.dgvFood, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvlma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidlma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhinh;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgveditanh;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}