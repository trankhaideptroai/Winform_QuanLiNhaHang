using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FHoaDon : Form
    {
        
        public FHoaDon()
        {
            InitializeComponent();
            GetOrder();
        }
        private void GetOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT * FROM dbo.HoaDon INNER JOIN dbo.BanAn\r\n\tON dbo.HoaDon.idTable = dbo.BanAn.maban\r\nWHERE dbo.HoaDon.trangthai = 0";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            FlowLayoutPanel p1;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Width = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Width = 350;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                System.Windows.Forms.Label lb1 = new System.Windows.Forms.Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;

                System.Windows.Forms.Label lb2 = new System.Windows.Forms.Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                System.Windows.Forms.Label lb3 = new System.Windows.Forms.Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;

                System.Windows.Forms.Label lb4 = new System.Windows.Forms.Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.AutoSize = true;

                lb1.Text = "Tên bàn: " + dt.Rows[i]["tenban"].ToString();
                lb2.Text = "Ngày tạo hóa đơn: " + dt.Rows[i]["dateCheckIn"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);

                p1.Controls.Add(p2);
                flowLayoutPanel1.Controls.Add(p1);


                int idhd = 0;
                idhd = Convert.ToInt32(dt.Rows[i]["idHD"].ToString());
                string query2 = "SELECT * FROM dbo.HoaDon b INNER JOIN dbo.HoaDonChiTiet bi\r\n\tON b.idHD = bi.idHD\r\n\t\t\t\t\t\t\tINNER JOIN dbo.MonAn f\r\n\tON bi.IdMon = f.IdMon\r\nWHERE b.idHD = " + idhd;
                
                DataTable dt2 = DataProvider.Instance.ExecuteQuery(query2);
                for(int j = 0; j < dt2.Rows.Count; j++)
                {
                    System.Windows.Forms.Label lb5 = new System.Windows.Forms.Label();
                    lb5.ForeColor = Color.Black;
                    lb5.Margin = new Padding(10, 5, 3, 0);
                    lb5.AutoSize = true;

                    int no = j + 1;
                    lb5.Text = "" + no + " " + dt2.Rows[j]["TenMon"].ToString() + " " + dt2.Rows[j]["SoLuong"].ToString();

                    p1.Controls.Add(lb5);
                }

                CustomButton btn = new CustomButton
                {
                    BorderRadius = 20,
                    BorderSize = 2,
                    BorderColor = Color.PaleVioletRed,
                    Size = new Size(100, 40),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(241, 85, 127),
                    Text = "Thanh toán",
                    

                };
                btn.Tag = dt.Rows[i]["idHD"].ToString();
                
                btn.Click += new EventHandler(btn_click);
                p1.Controls.Add(btn);
                flowLayoutPanel1.Controls.Add(p1);
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as CustomButton).Tag.ToString());
            
            if (id != -1)
            {
                if (MessageBox.Show($"Bạn có muốn thanh toán cho bàn này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAL.Instance.CheckOut(id);
                }
            }
            GetOrder();
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            GetOrder();
        }
    }
}
