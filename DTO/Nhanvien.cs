using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        private int idNV;
        private string hoten;
        private string sdt;
        private DateTime ngaysinh;
        private string email;
        private string matkhau;
        private string chucvu;
        private string phai;
        private string manv;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Manv { get => manv; set => manv = value; }
        public int IdNV { get => idNV; set => idNV = value; }

        public Nhanvien() { }
        public Nhanvien(DataRow row)
        {
            this.IdNV = Convert.ToInt32(row["IdNV"]);
            this.Manv = row["MaNV"] != DBNull.Value ? row["MaNV"].ToString() : null;
            this.Hoten = row["HoTen"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.Ngaysinh = Convert.ToDateTime(row["NgaySinh"]);
            this.Email = row["Email"].ToString();
            this.Matkhau = row["MatKhau"].ToString();
            this.Chucvu = row["ChucVu"].ToString();
            this.Phai = row["Phai"].ToString();
        }
    }
}
