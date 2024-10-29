using DAL;
using DTO;
using GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class FFoodView : SimpleView
    {
        public FFoodView()
        {
            InitializeComponent();
            dgvFood.AutoGenerateColumns = false;
        }
        public override void pictureBox1_Click(object sender, EventArgs e)
        {
            FFoodAdd foodAdd = new FFoodAdd();
            foodAdd.ShowDialog();
            LoadFood();
        }
        public void LoadFood()
        {

            List<Food> foodList = FoodDAL.Instance.GetAllMonAn();
            dgvFood.DataSource = foodList;
            dgvFood.Columns["dgvid"].DataPropertyName = "IdMon";
            dgvFood.Columns["dgvtenmon"].DataPropertyName = "TenMon";
            dgvFood.Columns["dgvgia"].DataPropertyName = "Gia";
            dgvFood.Columns["dgvlma"].DataPropertyName = "name";
            dgvFood.Columns["dgvhinh"].DataPropertyName = "HinhMonAn";
            dgvFood.Columns["dgvidlma"].DataPropertyName = "id";
            dgvFood.Columns["dgvhinh"].Visible = false;
            dgvFood.Columns["dgvidlma"].Visible = false;

        }

        private void FFoodView_Load(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FFoodAdd frm = new FFoodAdd();
                frm.action = 1;
                frm.id = Convert.ToInt32(dgvFood.CurrentRow.Cells["dgvid"].Value);
                frm.txtTenMon.Text = Convert.ToString(dgvFood.CurrentRow.Cells["dgvtenmon"].Value);
                frm.txtGia.Text = Convert.ToString(dgvFood.CurrentRow.Cells["dgvgia"].Value);
                frm.pbHinh.Enabled = false;
                frm.btnBrowse.Enabled = false;
               
                frm.ShowDialog();
                LoadFood();
            }
            if (dgvFood.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult result = MessageBox.Show("Bạn chắc muốn xóa món ăn này chứ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    int idmon = Convert.ToInt32(dgvFood.CurrentRow.Cells["dgvid"].Value);
                    Food monAn = new Food { IdMon = idmon };
                    FoodDAL.Instance.RemoveMonAn(monAn);
                    LoadFood();
                }
            }
            if (dgvFood.CurrentCell.OwningColumn.Name == "dgveditanh")
            {
                FFoodAdd frm = new FFoodAdd();
                frm.action = 3;
                frm.id = Convert.ToInt32(dgvFood.CurrentRow.Cells["dgvid"].Value);
                frm.txtTenMon.Text = Convert.ToString(dgvFood.CurrentRow.Cells["dgvtenmon"].Value);
                frm.txtGia.Text = Convert.ToString(dgvFood.CurrentRow.Cells["dgvgia"].Value);

                // Set giá trị ComboBox
                int loaiMonAnId = Convert.ToInt32(dgvFood.CurrentRow.Cells["dgvidlma"].Value);
                frm.idLoaiMonAn = loaiMonAnId;
                frm.txtGia.Enabled = false;
                frm.txtLMA.Enabled = false;
                frm.txtTenMon.Enabled = false;

                byte[] imageBytes = (byte[])(dgvFood.CurrentRow.Cells["dgvhinh"].Value);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        frm.pbHinh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    frm.pbHinh.Image = null; // Không phải là frm.pbHinh = null
                }
                frm.ShowDialog();
                LoadFood();
            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            List<Food> foodsearch = FoodDAL.Instance.Search_MonAN(txtTimKiem.Text);
            dgvFood.DataSource = foodsearch;
            dgvFood.Columns["dgvid"].DataPropertyName = "IdMon";
            dgvFood.Columns["dgvtenmon"].DataPropertyName = "TenMon";
            dgvFood.Columns["dgvgia"].DataPropertyName = "Gia";
            dgvFood.Columns["dgvlma"].DataPropertyName = "name";
            dgvFood.Columns["dgvhinh"].DataPropertyName = "HinhMonAn";
            dgvFood.Columns["dgvidlma"].DataPropertyName = "id";
            dgvFood.Columns["dgvhinh"].Visible = false;
            dgvFood.Columns["dgvidlma"].Visible = false;

        }
    }
}
