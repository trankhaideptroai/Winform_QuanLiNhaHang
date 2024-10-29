using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SPNhapKhoDAL
    {
        public bool Execute(string proc, params SqlParameter[] para)
        {
            using (SqlConnection con = DataProvider2.connect())
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = proc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(para);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    con.Close();
                    return false;
                }
            }
        }

        // Tải danh sách
        public DataTable loadlist()
        {
            using (SqlConnection con = DataProvider2.connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_nhkh_load", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
                return dt;
            }
        }

        // Thêm
        public bool insert(SPNhapKho sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("@maloai", sp.Maloai),
                new SqlParameter("@tensp", sp.Ten),
                new SqlParameter("@soluong", sp.Soluong),
                new SqlParameter("@ngaynh", sp.Ngnh),
                new SqlParameter("@hsd", sp.Hsd),
                new SqlParameter("@ncc", sp.Ncc),
                new SqlParameter("@email", sp.Email)
            };
            return Execute("sp_nhkh_insert", para);
        }

        // Xóa
        public bool delete(string maloai)
        {
            return Execute("sp_nhkh_del", new SqlParameter("@maloai", maloai));
        }

        // Sửa
        public bool update(SPNhapKho sp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("@maloai", sp.Maloai),
                new SqlParameter("@tensp", sp.Ten),
                new SqlParameter("@soluong", sp.Soluong),
                new SqlParameter("@ngaynh", sp.Ngnh),
                new SqlParameter("@hsd", sp.Hsd),
                new SqlParameter("@ncc", sp.Ncc),
                new SqlParameter("@email", sp.Email)
            };
            return Execute("sp_nhkh_upd", para);
        }

        // Tìm kiếm
        public DataTable finding(string tensp)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC Search_NhapKho @ten", new object[] { tensp });
            return dt;
        }

    }
}
