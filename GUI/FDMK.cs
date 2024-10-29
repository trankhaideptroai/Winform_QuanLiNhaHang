using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FDMK : Form
    {
        private string email;
        Thread th;
        NhanVienBUS busnhanvien = new NhanVienBUS();
        NhanVienDNBUS NhanVienDNBUS = new NhanVienDNBUS();
        public Form1 MainForm { get; set; }  // Thêm thuộc tính để giữ tham chiếu tới Form1

        public FDMK()
        {
            InitializeComponent();
        }

        public FDMK(string user)
        {
            InitializeComponent();
            this.email = user;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.Focus();
                return;
            }
            else if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauMoi.Focus();
                return;
            }
            else if (txtMatKhauMoi2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauMoi2.Focus();
                return;
            }
            else if (txtMatKhauMoi2.Text.Trim() != txtMatKhauMoi.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật khẩu và nhập lại mật khẩu giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauMoi.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = NhanVienDNBUS.EncryptPassword(txtMatKhauMoi.Text);
                    string matkhaucu = NhanVienDNBUS.EncryptPassword(txtMatKhauCu.Text);
                    if (busnhanvien.UpdateMatKhau(txt_taikhoan.Text, matkhaucu, matkhaumoi))
                    {
                        // Cập nhật thành công, ẩn Form1
                        if (MainForm != null)
                        {
                            MainForm.Hide();  // Hoặc MainForm.Close() nếu bạn muốn đóng Form1
                        }
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                        FLogin loginForm = new FLogin();
                        loginForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, Cập nhật mật khẩu không thành công");
                        txtMatKhauCu.Clear();
                        txtMatKhauMoi.Clear();
                        txtMatKhauMoi2.Clear();
                    }
                }
                else
                {
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                    txtMatKhauMoi2.Clear();
                }
            }
        }

        private void FDMK_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Enabled = false;
            txt_taikhoan.Text = email;
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString("x2"));  // Chuyển đổi thành hex
            }
            return encryptdata.ToString();
        }
    }
}
