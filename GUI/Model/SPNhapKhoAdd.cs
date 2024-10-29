using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.Model
{
    public partial class SPNhapKhoAdd : SimpleAdd
    {
        private string email;
        SPNhapKhoBUS spnk = new SPNhapKhoBUS();
        public SPNhapKhoAdd()
        {
            InitializeComponent();
        }

        bool checksoluong()
        {
            SPNhapKho nk = new SPNhapKho();
            int chksl;
            if(int.TryParse(txtSoLuong.Text, out chksl) && chksl > 0)
            {
                nk.Soluong = chksl;
                return true;
            }
            else
            {
                MessageBox.Show("Số lượng là số không phải chữ", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public SPNhapKhoAdd(string user)
        {
            InitializeComponent();
            this.email = user;
        }
        public int action = 0;
        public string emailnvnhap = string.Empty;

        public string id = string.Empty;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                if (string.IsNullOrEmpty(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Nhắc nhở", MessageBoxButtons.OK);
                    txtEmail.Focus();
                } else if (string.IsNullOrEmpty(txtSoLuong.Text) || !checksoluong())
                {
                    txtSoLuong.Focus();
                }
                else if (string.IsNullOrEmpty(txtNhaCC.Text))
                {
                    MessageBox.Show("Vui lòng nhập nhà cung cấp", "Nhắc nhở", MessageBoxButtons.OK);
                    txtNhaCC.Focus();
                }
                else
                {
                    SPNhapKho nk = new SPNhapKho();
                    {
                        nk.Maloai = txtMaLoai.Text;
                        nk.Ten = txtTenSP.Text;
                        nk.Soluong = Convert.ToInt32(txtSoLuong.Text);
                        nk.Ngnh = txtNgayNhap.Value;
                        nk.Ncc = txtNhaCC.Text;
                        nk.Hsd = txtHSD.Value;
                        nk.Email = txtEmail.Text;
                    }
                    spnk.Insert(nk);
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }  
            }
            if (action == 1)
            {
                if (string.IsNullOrEmpty(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Nhắc nhở", MessageBoxButtons.OK);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên số lượng", "Nhắc nhở", MessageBoxButtons.OK);
                    txtSoLuong.Focus();
                }
                else if (string.IsNullOrEmpty(txtNhaCC.Text))
                {
                    MessageBox.Show("Vui lòng nhập nhà cung cấp", "Nhắc nhở", MessageBoxButtons.OK);
                    txtNhaCC.Focus();
                }
                else
                {
                    SPNhapKho nk = new SPNhapKho();
                    {
                        nk.Maloai = txtMaLoai.Text;
                        nk.Ten = txtTenSP.Text;
                        nk.Soluong = int.Parse(txtSoLuong.Text);
                        nk.Ngnh = txtNgayNhap.Value;
                        nk.Ncc = txtNhaCC.Text;
                        nk.Hsd = txtHSD.Value;
                        nk.Email = txtEmail.Text;
                    }
                    spnk.Update(nk);
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();

                }

                 
            }
            }
        public override void SimpleAdd_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
            if(action == 1)
            {
                txtEmail.Text = emailnvnhap;
            }
        }

        private void SPNhapKhoAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
