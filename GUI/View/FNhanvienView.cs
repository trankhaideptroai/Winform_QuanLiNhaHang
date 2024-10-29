using BUS;
using DAL;
using DTO;
using GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class FNhanVienView : SimpleView
    {
        NhanVienBUS busnhanvien = new NhanVienBUS();
        NhanVienDAL dalnhanvien = new NhanVienDAL();
        public FNhanVienView()
        {
            InitializeComponent();
            dgvNhanVien.AutoGenerateColumns = false;
        }
        public void LoadNhanVien()
        {

            dgvNhanVien.DataSource = busnhanvien.getNhanVien();
            dgvNhanVien.Columns["dgvmanv"].DataPropertyName = "Manv";
            dgvNhanVien.Columns["dgvhoten"].DataPropertyName = "Hoten";
            dgvNhanVien.Columns["dgvsdt"].DataPropertyName = "Sdt";
            dgvNhanVien.Columns["dgvngaysinh"].DataPropertyName = "Ngaysinh";
            dgvNhanVien.Columns["dgvemail"].DataPropertyName = "Email";

            dgvNhanVien.Columns["dgvchucvu"].DataPropertyName = "Chucvu";
            dgvNhanVien.Columns["dgvphai"].DataPropertyName = "Phai";

        }

        private void FNhanVienView_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        public override void pictureBox1_Click(object sender, EventArgs e)
        {
            FNhanvienAdd nhanvienAdd = new FNhanvienAdd();
            nhanvienAdd.ShowDialog();
            LoadNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                FNhanvienAdd frm = new FNhanvienAdd();
                frm.action = 1;
                frm.id = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvmanv"].Value);
                frm.txtTenNhanVien.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvhoten"].Value);
                frm.txtChucVu.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvchucvu"].Value);
                frm.txtEmail.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvemail"].Value);
                frm.txtPhai.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvphai"].Value);
                frm.txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvsdt"].Value);
                frm.txtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvngaysinh"].Value);
                frm.ShowDialog();
                LoadNhanVien();
            }
            if (dgvNhanVien.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult result = MessageBox.Show("Bạn chắc muốn xóa nhân viên này chứ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string manv = Convert.ToString(dgvNhanVien.CurrentRow.Cells["dgvmanv"].Value);
                    Nhanvien nv = new Nhanvien();
                    {
                        nv.Manv = manv;
                    }
                    busnhanvien.Deletenhanvien(nv);
                    LoadNhanVien();

                }

            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            List<Nhanvien> nhanvienSearch = new List<Nhanvien>();
            dgvNhanVien.DataSource = dalnhanvien.Search_Nhanvien(txtTimKiem.Text);



        }
    }
}

