using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SPNhapKho
    {
        private string maloai;
        private string ten;
        private int soluong;
        private DateTime ngnh;
        private DateTime hsd;
        private string ncc;
        private string email;
        private int idNV;

        public string Maloai { get => maloai; set => maloai = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                {
                    soluong = value;
                }
            }
        }
        public DateTime Ngnh { get => ngnh; set => ngnh = value; }
        public DateTime Hsd { get => hsd; set => hsd = value; }
        public string Ncc { get => ncc; set => ncc = value; }
        public string Email { get => email; set => email = value; }
        public int IdNV { get => idNV; set => idNV = value; }

        public SPNhapKho() { }

        public SPNhapKho(DataRow row)
        {
            this.Maloai = row["MaLoai"].ToString();
            this.Ten = row["TenSP"].ToString();
            this.Soluong = int.Parse(row["SoLuong"].ToString());
            this.Ngnh = DateTime.Parse(row["NgayNhap"].ToString());
            this.Hsd = DateTime.Parse(row["HSD"].ToString());
            this.Ncc = row["NhaCungCap"].ToString();
            this.Email = row["Email"].ToString(); // Adjust if the column name is different
            this.IdNV = int.Parse(row["IdNV"].ToString());
        }
    }
}
