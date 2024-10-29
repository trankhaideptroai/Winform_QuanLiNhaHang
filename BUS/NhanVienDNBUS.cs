using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienDNBUS
    {
        NhanVienDNDAL dAL_NhanVien = new NhanVienDNDAL();
        public bool checklogin(string email, string password)
        {

            return dAL_NhanVien.CheckLogin(email, password);
        }
        public string GetUserRole(string email)
        {
            return dAL_NhanVien.GetUserRole(email);
        }
        public string EncryptPassword(string password)
        {
            return dAL_NhanVien.EncryptPassword(password);
        }
    }
}
