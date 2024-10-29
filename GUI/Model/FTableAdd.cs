using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace GUI.Model
{
    public partial class FTableAdd : SimpleAdd
    {
        public FTableAdd()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            action = 0;
        }
        public int action = 0;

        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                if (string.IsNullOrEmpty(txtTenBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenBan.Focus();
                }else if(txtTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái bàn ăn!", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                {
                    Table banAn = new Table();
                    {
                        banAn.TenBan = txtTenBan.Text;
                        banAn.TrangThai = txtTrangThai.Text;
                    }
                    TableDAL.Instance.Insert_BanAn(banAn);
                    MessageBox.Show("Thêm bàn ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            if (action == 1)
            {
                if (string.IsNullOrEmpty(txtTenBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenBan.Focus();
                }
                else if (txtTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái bàn ăn!", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                {
                    Table banAn = new Table();
                    {
                        banAn.MaBan = id;
                        banAn.TenBan = txtTenBan.Text;
                        banAn.TrangThai = txtTrangThai.Text;
                    }
                    TableDAL.Instance.Update_BanAn(banAn);
                    MessageBox.Show("Sửa bàn ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            

           
        }
    }
}
