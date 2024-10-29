using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader rdr;
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6P7HGD3;Initial Catalog=qlnhahang;Integrated Security=True");

        //lấy danh sách nhân viên 
        public DataTable getNhanVien()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("DSNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        // Thêm nhân viên
        public bool InsertNhanvien(Nhanvien nv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("themnhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("MaNV" , nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.Hoten);
                cmd.Parameters.AddWithValue("@SDT", nv.Sdt);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@ChucVu", nv.Chucvu);
                cmd.Parameters.AddWithValue("@phai", nv.Phai);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //Sửa nhân viên
        public bool UpdateNhanvien(Nhanvien nv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("CapNhatDSNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.Manv);
                cmd.Parameters.AddWithValue("@HoTen", nv.Hoten);
                cmd.Parameters.AddWithValue("@SDT", nv.Sdt);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                
                cmd.Parameters.AddWithValue("@ChucVu", nv.Chucvu);
                cmd.Parameters.AddWithValue("@phai", nv.Phai);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //Xóa nhân viên
        public bool DeleteNhanvien(Nhanvien nv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("XoaDSNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.Manv);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        //Tìm kiếm nhân viên 
        public DataTable Search_Nhanvien(string tennv)
        {
            DataTable dt = new DataTable(); 
            dt = DataProvider.Instance.ExecuteQuery("EXEC Search_NhanVien @tennv ", new object[] { tennv });
            return dt;
        }
        public bool UpdateMatKhau(string email, string matkhauCu, string matkhauMoi)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DoiMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhauCu", matkhauCu);
                cmd.Parameters.AddWithValue("matkhauMoi", matkhauMoi);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally { conn?.Close(); }
            return false;
        }



    }
}
