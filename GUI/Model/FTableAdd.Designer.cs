namespace GUI.Model
{
    partial class FTableAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTableAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBan = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThai = new Guna.UI.WinForms.GunaComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(505, 134);
            // 
            // lbl1
            // 
            this.lbl1.Size = new System.Drawing.Size(179, 38);
            this.lbl1.Text = "Thêm bàn ăn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 333);
            this.gunaPanel2.Size = new System.Drawing.Size(505, 86);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 7);
            this.btnSave.Text = "Lưu";
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(253, 7);
            this.btnCLose.Text = "Thoát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bàn";
            // 
            // txtTenBan
            // 
            this.txtTenBan.BaseColor = System.Drawing.Color.White;
            this.txtTenBan.BorderColor = System.Drawing.Color.Silver;
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(77, 175);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(321, 41);
            this.txtTenBan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.txtTrangThai.BaseColor = System.Drawing.Color.White;
            this.txtTrangThai.BorderColor = System.Drawing.Color.Silver;
            this.txtTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.FormattingEnabled = true;
            this.txtTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.txtTrangThai.Location = new System.Drawing.Point(77, 279);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTrangThai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtTrangThai.Size = new System.Drawing.Size(321, 39);
            this.txtTrangThai.TabIndex = 6;
            // 
            // FTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 419);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.label1);
            this.Name = "FTableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTableAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTenBan, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTrangThai, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtTenBan;
        public Guna.UI.WinForms.GunaComboBox txtTrangThai;
    }
}