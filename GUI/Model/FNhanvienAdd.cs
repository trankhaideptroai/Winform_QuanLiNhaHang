using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Model
{
    public partial class FNhanvienAdd : SimpleAdd
    {
        NhanVienBUS busnhanvien = new NhanVienBUS();
        public FNhanvienAdd()
        {
            InitializeComponent();
        }
        public int action = 0;

        public string id = string.Empty;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenNhanVien.Focus();
                }
                else if (txtChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn chức vụ", "Nhắc nhở", MessageBoxButtons.OK);
                    
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email", "Nhắc nhở", MessageBoxButtons.OK);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtNgaySinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh", "Nhắc nhở", MessageBoxButtons.OK);
                    txtNgaySinh.Focus();
                }
                else if (txtPhai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại", "Nhắc nhở", MessageBoxButtons.OK);
                    txtSDT.Focus();
                }
                else
                {
                    Nhanvien nv = new Nhanvien();
                    {
                        nv.Hoten = txtTenNhanVien.Text;
                        nv.Sdt = txtSDT.Text;
                        nv.Ngaysinh = txtNgaySinh.Value;
                        nv.Email = txtEmail.Text;
                        nv.Chucvu = txtChucVu.Text;
                        nv.Phai = txtPhai.Text;

                    }
                    busnhanvien.Insertnhanvien(nv);
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            if (action == 1)
            {
                if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenNhanVien.Focus();
                }
                else if (txtChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn chức vụ", "Nhắc nhở", MessageBoxButtons.OK);

                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập email", "Nhắc nhở", MessageBoxButtons.OK);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtNgaySinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh", "Nhắc nhở", MessageBoxButtons.OK);
                    txtNgaySinh.Focus();
                }
                else if (txtPhai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại", "Nhắc nhở", MessageBoxButtons.OK);
                    txtSDT.Focus();
                }
                else
                {
                    Nhanvien nv = new Nhanvien();
                    {
                        nv.Manv = id;
                        nv.Hoten = txtTenNhanVien.Text;
                        nv.Sdt = txtSDT.Text;
                        nv.Ngaysinh = txtNgaySinh.Value;
                        nv.Email = txtEmail.Text;
                        nv.Chucvu = txtChucVu.Text;
                        nv.Phai = txtPhai.Text;

                    }
                    busnhanvien.Updatenhanvien(nv);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }

        }
    }
}
