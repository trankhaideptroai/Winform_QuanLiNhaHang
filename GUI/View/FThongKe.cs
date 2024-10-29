using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace GUI.View
{
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
            dgvThongKe.AutoGenerateColumns = false;
            

        }
        
        private void LoadThongKe(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            using (SqlConnection conn = DataProvider2.connect())
            {
                try
                {
                    // Mở kết nối tới cơ sở dữ liệu
                    conn.Open();

                    // Tạo đối tượng SqlCommand để gọi stored procedure "timkiemTk"
                    using (SqlCommand cmd = new SqlCommand("tkThongKeDoanhThuTheoNgay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Thêm tham số @NgayBatDau và @NgayKetThuc vào stored procedure
                        cmd.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);

                        // Sử dụng SqlDataAdapter để lấy dữ liệu từ stored procedure
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        // Gán dữ liệu vào DataGridView để hiển thị
                        dgvThongKe.DataSource = dt;
                        dgvThongKe.Columns["dgvngay"].DataPropertyName = "Ngay";
                        dgvThongKe.Columns["dgvtongtien"].DataPropertyName = "TongTien";
                        dgvThongKe.Columns["dgvsoluong"].DataPropertyName = "slhd";
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các DateTimePicker và gọi hàm LoadData
            DateTime ngaybatdau = txtNgayBatDau.Value;
            DateTime ngayketthuc = txtNgayKetThuc.Value;
            LoadThongKe(ngaybatdau, ngayketthuc);
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Lưu file PDF";
            saveFileDialog.FileName = "exported_data.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = saveFileDialog.FileName;
                Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

                try
                {
                    // Tạo đối tượng PdfWriter để ghi dữ liệu vào file PDF
                    PdfWriter.GetInstance(pdfDoc, new FileStream(pdfPath, FileMode.Create));
                    pdfDoc.Open();

                    // Tạo bảng PdfPTable với số cột bằng số cột của DataGridView
                    PdfPTable pdfTable = new PdfPTable(dgvThongKe.Columns.Count);

                    // Đặt độ rộng các cột của bảng
                    float[] widths = new float[dgvThongKe.Columns.Count];
                    for (int i = 0; i < dgvThongKe.Columns.Count; i++)
                    {
                        widths[i] = (float)dgvThongKe.Columns[i].Width;
                    }
                    pdfTable.SetWidths(widths);

                    // Thêm tiêu đề các cột vào bảng
                    foreach (DataGridViewColumn column in dgvThongKe.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    // Thêm dữ liệu các dòng vào bảng
                    foreach (DataGridViewRow row in dgvThongKe.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                        }
                    }

                    // Thêm bảng vào tài liệu PDF
                    pdfDoc.Add(pdfTable);

                    // Hiển thị thông báo khi xuất file PDF thành công
                    MessageBox.Show("Dữ liệu đã được xuất ra file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra khi xuất file PDF
                    MessageBox.Show("Có lỗi xảy ra khi xuất file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đóng tài liệu PDF
                    pdfDoc.Close();
                }
            }
        }

        private void txtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
