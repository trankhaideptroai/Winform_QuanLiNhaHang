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
    public class NhanVienBUS
    {
        NhanVienDAL dalnhanvien = new NhanVienDAL();
        public DataTable getNhanVien()
        {
            return dalnhanvien.getNhanVien();
        }

        public bool UpdateMatKhau(string email, string matkhauCu, string matkhauMoi)
        {
            return dalnhanvien.UpdateMatKhau(email, matkhauCu, matkhauMoi);
        }



        public bool Insertnhanvien(Nhanvien nv)
        {
            return dalnhanvien.InsertNhanvien(nv);
        }

        public bool Updatenhanvien(Nhanvien nv)
        {
            return dalnhanvien.UpdateNhanvien(nv);
        }

        public bool Deletenhanvien(Nhanvien nv)
        {
            return dalnhanvien.DeleteNhanvien(nv);
        }

        

    }
}
