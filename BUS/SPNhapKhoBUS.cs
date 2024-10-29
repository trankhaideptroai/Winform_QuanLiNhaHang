using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SPNhapKhoBUS
    {
        SPNhapKhoDAL sp2 = new SPNhapKhoDAL();
        // Tải danh sách
        public DataTable Load()
        {
            return sp2.loadlist();
        }

        // Thêm
        public bool Insert(SPNhapKho sp)
        {
            return sp2.insert(sp);
        }

        // Xóa
        public bool Delete(string masp)
        {
            return sp2.delete(masp);
        }

        // Sửa
        public bool Update(SPNhapKho sp)
        {
            return sp2.update(sp);
        }

        // Tìm kiếm
        public DataTable Find(string tensp)
        {
            return sp2.finding(tensp);
        }
    }
}
