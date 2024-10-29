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
    public partial class FSPNhapKhoView : SimpleView
    {
        private string email;
        SPNhapKhoBUS spnk = new SPNhapKhoBUS();
        public FSPNhapKhoView()
        {
            InitializeComponent();
            dgvSPNK.AutoGenerateColumns = false;
        }
        public FSPNhapKhoView(string user)
        {
            InitializeComponent();
            dgvSPNK.AutoGenerateColumns = false;
            this.email = user;
        }
        public void LoadSPNK()
        {

            dgvSPNK.DataSource = spnk.Load();
            dgvSPNK.Columns["dgvmaloai"].DataPropertyName = "Maloai";
            dgvSPNK.Columns["dgvtensp"].DataPropertyName = "TenSP";
            dgvSPNK.Columns["dgvsoluong"].DataPropertyName = "Soluong";
            dgvSPNK.Columns["dgvngaynhap"].DataPropertyName = "NgayNhap";
            dgvSPNK.Columns["dgvhsd"].DataPropertyName = "Hsd";
            dgvSPNK.Columns["dgvncc"].DataPropertyName = "NhaCungCap";
            dgvSPNK.Columns["dgvidnv"].DataPropertyName = "IdNV";
            dgvSPNK.Columns["dgvemail"].DataPropertyName = "Email";
            dgvSPNK.Columns["dgvidnv"].Visible = false;
            dgvSPNK.Columns["dgvemail"].Visible = false;



        }

        private void FSPNhapKhoView_Load(object sender, EventArgs e)
        {
            LoadSPNK();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SPNhapKhoAdd frm = new SPNhapKhoAdd(email);
            frm.ShowDialog();
            LoadSPNK();
        }

        private void dgvSPNK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSPNK.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                SPNhapKhoAdd frm = new SPNhapKhoAdd();
                frm.action = 1;
                
                frm.txtMaLoai.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvmaloai"].Value);
                frm.txtTenSP.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvtensp"].Value);
                frm.txtSoLuong.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvsoluong"].Value);
                frm.txtNhaCC.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvncc"].Value);
                frm.emailnvnhap = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvemail"].Value);
                frm.txtHSD.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvhsd"].Value);
                frm.txtNgayNhap.Text = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvngaynhap"].Value);

                frm.ShowDialog();
                LoadSPNK();
            }
            if (dgvSPNK.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult result = MessageBox.Show("Bạn chắc muốn xóa nhân viên này chứ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string masp = Convert.ToString(dgvSPNK.CurrentRow.Cells["dgvmaloai"].Value);
                    
                    spnk.Delete(masp);
                    LoadSPNK();
                }

            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            dgvSPNK.DataSource = spnk.Find(txtTimKiem.Text);
            dgvSPNK.Columns["dgvmaloai"].DataPropertyName = "Maloai";
            dgvSPNK.Columns["dgvtensp"].DataPropertyName = "TenSP";
            dgvSPNK.Columns["dgvsoluong"].DataPropertyName = "Soluong";
            dgvSPNK.Columns["dgvngaynhap"].DataPropertyName = "NgayNhap";
            dgvSPNK.Columns["dgvhsd"].DataPropertyName = "Hsd";
            dgvSPNK.Columns["dgvncc"].DataPropertyName = "NhaCungCap";
            dgvSPNK.Columns["dgvidnv"].DataPropertyName = "IdNV";
            dgvSPNK.Columns["dgvemail"].DataPropertyName = "Email";
            dgvSPNK.Columns["dgvidnv"].Visible = false;
            dgvSPNK.Columns["dgvemail"].Visible = false;
        }
    }
}
