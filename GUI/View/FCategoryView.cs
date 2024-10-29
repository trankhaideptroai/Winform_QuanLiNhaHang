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
    public partial class FCategoryView : SimpleView
    {
        public FCategoryView()
        {
            InitializeComponent();
            dgvLoaiMonAn.AutoGenerateColumns = false;
        }
        public void LoadCategory()
        {
            List<Category> categoryList = CategoryDAL.Instance.GetListCategory();
            dgvLoaiMonAn.DataSource = categoryList;
            dgvLoaiMonAn.Columns["dgvid"].DataPropertyName = "ID";
            dgvLoaiMonAn.Columns["dgvname"].DataPropertyName = "Name";
        }

        private void FCategoryView_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        public override void pictureBox1_Click(object sender, EventArgs e)
        {
            FCategoryAdd categoryAdd = new FCategoryAdd();
            categoryAdd.ShowDialog();
            LoadCategory();
        }
        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLoaiMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiMonAn.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                FCategoryAdd frm = new FCategoryAdd();
                frm.action = 1;
                frm.id = Convert.ToInt32(dgvLoaiMonAn.CurrentRow.Cells["dgvid"].Value);
                frm.txtCategory.Text = Convert.ToString(dgvLoaiMonAn.CurrentRow.Cells["dgvname"].Value);
                frm.ShowDialog();
                LoadCategory();
            }
            if (dgvLoaiMonAn.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult result = MessageBox.Show("Bạn chắc muốn xóa loại thức ăn này chứ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(dgvLoaiMonAn.CurrentRow.Cells["dgvid"].Value);
                    Category loaiMonAn = new Category();
                    {
                        loaiMonAn.ID = id;
                    }
                    CategoryDAL.Instance.RemoveCategory(loaiMonAn);
                    LoadCategory();

                }

            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            List<Category> categoryList = CategoryDAL.Instance.Search_LoaiMonAn(txtTimKiem.Text);
            dgvLoaiMonAn.DataSource = categoryList;
            dgvLoaiMonAn.Columns["dgvid"].DataPropertyName = "ID";
            dgvLoaiMonAn.Columns["dgvname"].DataPropertyName = "Name";
        }
    }
}
