using DAL;
using DTO;
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

namespace GUI.Model
{
    public partial class FFoodAdd : SimpleAdd
    {
        public FFoodAdd()
        {
            InitializeComponent();
        }
        public int action = 0;
        public int idLoaiMonAn;
        public int id = 0;


        private string imagePath = string.Empty;
        private byte[] getPhoto()
        {
            if(pbHinh.Image != null)
    {
                using (MemoryStream stream = new MemoryStream())
                {
                    pbHinh.Image.Save(stream, pbHinh.Image.RawFormat);
                    return stream.ToArray();
                }
            }
            return null; // 
        }

        public void LoadLMA()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiMonAn");
            txtLMA.DataSource = dt;
            txtLMA.DisplayMember = "name";
            txtLMA.ValueMember = "id";
        }
    

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (action == 0)
            {
                if (string.IsNullOrEmpty(txtTenMon.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên món", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenMon.Focus();
                }
                else if (string.IsNullOrEmpty(txtGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá cho món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                    txtGia.Focus();
                }else if(txtLMA.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                {
                    Food monAn = new Food();
                    {
                        monAn.TenMon = (txtTenMon.Text);
                        monAn.Gia = float.Parse(txtGia.Text);
                        monAn.IdLoaiMonAn = int.Parse(txtLMA.SelectedValue.ToString());
                        monAn.HinhMonAn = getPhoto();
                    }
                    FoodDAL.Instance.AddMonAn(monAn);
                    
                    MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            if (action == 1)
            {
                if (string.IsNullOrEmpty(txtTenMon.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên món", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenMon.Focus();
                }
                else if (string.IsNullOrEmpty(txtGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá cho món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                    txtGia.Focus();
                }
                else if (txtLMA.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                {
                    Food monAn = new Food();
                    {
                        monAn.IdMon = id;
                        monAn.TenMon = (txtTenMon.Text);
                        monAn.Gia = float.Parse(txtGia.Text);
                        monAn.IdLoaiMonAn = int.Parse(txtLMA.SelectedValue.ToString());
                    }
                    FoodDAL.Instance.UpdateMonAn(monAn);
                    MessageBox.Show("Sửa món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            if (action == 3)
            {
                if (string.IsNullOrEmpty(txtTenMon.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên món", "Nhắc nhở", MessageBoxButtons.OK);
                    txtTenMon.Focus();
                }
                else if (string.IsNullOrEmpty(txtGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá cho món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                    txtGia.Focus();
                }
                else if (txtLMA.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại món ăn", "Nhắc nhở", MessageBoxButtons.OK);
                }
                else
                {
                    Food monAn = new Food();
                    {
                        monAn.IdMon = id;
                        monAn.HinhMonAn = getPhoto();
                    }
                    FoodDAL.Instance.UpdateMonAn2(monAn);
                    MessageBox.Show("Sửa món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbHinh.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        public override void SimpleAdd_Load(object sender, EventArgs e)
        {
            LoadLMA(); // Tải dữ liệu loại món ăn vào ComboBox
            txtLMA.SelectedValue = idLoaiMonAn;
        }
    

    private void btnCLose_Click_1(object sender, EventArgs e)
        {

        }
    }
}
