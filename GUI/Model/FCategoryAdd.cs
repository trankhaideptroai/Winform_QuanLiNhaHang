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
    public partial class FCategoryAdd : SimpleAdd
    {
        public FCategoryAdd()
        {
            InitializeComponent();
        }
        public int action = 0;

        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK);
                    txtCategory.Focus();
                }
                else
                {
                    Category loaiMonAn = new Category();
                    {
                        loaiMonAn.Name = txtCategory.Text;
                    }
                    CategoryDAL.Instance.AddCategory(loaiMonAn);
                    MessageBox.Show("Thêm loại món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            if (action == 1)
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK);
                    txtCategory.Focus();
                }
                else
                {
                    Category loaiMonAn = new Category();
                    {
                        loaiMonAn.ID = id;
                        loaiMonAn.Name = txtCategory.Text;
                    }
                    CategoryDAL.Instance.UpdateCategory(loaiMonAn);
                    MessageBox.Show("Sửa loại món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }

        }

    }
}
