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
    public partial class FTableView : SimpleView
    {
        public FTableView()
        {
            InitializeComponent();
            dgvTable.AutoGenerateColumns = false;
        }
        public void LoadTable()
        {

            List<Table> tableList = TableDAL.Instance.LoadTableList();
            dgvTable.DataSource = tableList;
            dgvTable.Columns["dgvmaban"].DataPropertyName = "MaBan";
            dgvTable.Columns["dgvtenban"].DataPropertyName = "TenBan";
            dgvTable.Columns["dgvtrangthai"].DataPropertyName = "TrangThai";

        }
        private void FTableView_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        public override void pictureBox1_Click(object sender, EventArgs e)
        {
            FTableAdd tableADD = new FTableAdd();
            tableADD.ShowDialog();
            LoadTable();
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTable.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                
                FTableAdd frm = new FTableAdd();
                frm.action = 1;
                frm.id = Convert.ToInt32(dgvTable.CurrentRow.Cells["dgvmaban"].Value);
                frm.txtTenBan.Text = Convert.ToString(dgvTable.CurrentRow.Cells["dgvtenban"].Value);
                frm.txtTrangThai.Text = Convert.ToString(dgvTable.CurrentRow.Cells["dgvtrangthai"].Value);
                frm.ShowDialog();
                LoadTable();
            }if(dgvTable.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult result = MessageBox.Show("Bạn chắc muốn xóa bàn ăn này chứ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    int maban = Convert.ToInt32(dgvTable.CurrentRow.Cells["dgvmaban"].Value);
                    Table banAn = new Table();
                    {
                        banAn.MaBan = maban;
                    }
                    TableDAL.Instance.Delete_BanAn(banAn);
                    LoadTable();

                }
                
            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            List<Table> tableList = TableDAL.Instance.Search_BanAn(txtTimKiem.Text);
            dgvTable.DataSource = tableList;
            dgvTable.Columns["dgvmaban"].DataPropertyName = "MaBan";
            dgvTable.Columns["dgvtenban"].DataPropertyName = "TenBan";
            dgvTable.Columns["dgvtrangthai"].DataPropertyName = "TrangThai";
        }
    }
}
