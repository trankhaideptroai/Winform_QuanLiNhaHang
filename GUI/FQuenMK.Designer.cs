namespace GUI
{
    partial class FQuenMK
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email_quenmk = new Guna.UI.WinForms.GunaTextBox();
            this.btn_laymk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập email";
            // 
            // txt_email_quenmk
            // 
            this.txt_email_quenmk.BaseColor = System.Drawing.Color.White;
            this.txt_email_quenmk.BorderColor = System.Drawing.Color.Silver;
            this.txt_email_quenmk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email_quenmk.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_email_quenmk.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_email_quenmk.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email_quenmk.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_quenmk.Location = new System.Drawing.Point(276, 213);
            this.txt_email_quenmk.Name = "txt_email_quenmk";
            this.txt_email_quenmk.PasswordChar = '\0';
            this.txt_email_quenmk.SelectedText = "";
            this.txt_email_quenmk.Size = new System.Drawing.Size(470, 46);
            this.txt_email_quenmk.TabIndex = 16;
            // 
            // btn_laymk
            // 
            this.btn_laymk.Location = new System.Drawing.Point(367, 333);
            this.btn_laymk.Name = "btn_laymk";
            this.btn_laymk.Size = new System.Drawing.Size(165, 80);
            this.btn_laymk.TabIndex = 17;
            this.btn_laymk.Text = "Lấy mật khẩu";
            this.btn_laymk.UseVisualStyleBackColor = true;
            this.btn_laymk.Click += new System.EventHandler(this.btn_laymk_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(804, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_laymk);
            this.Controls.Add(this.txt_email_quenmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FQuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQuenMK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_email_quenmk;
        private System.Windows.Forms.Button btn_laymk;
        private System.Windows.Forms.Button button1;
    }
}