using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        //public Food(int idMon, string tenmon, int idLoaiMonAn, float gia, byte[] hinhMonAn)
        //{
        //    this.IDMon = idMon;
        //    this.Tenmon = tenmon;
        //    this.IDLoaiMonAn = idLoaiMonAn;
        //    this.Gia = gia;
        //    this.HinhMonAn = hinhMonAn;
        //}
        //public Food(string tenmon, float gia, int idLoaiMonAn, byte[] hinhMonAn)
        //{
        //    this.Tenmon = tenmon;
        //    this.Gia = gia;
        //    this.IDLoaiMonAn = idLoaiMonAn;
        //    this.HinhMonAn = hinhMonAn ;
        //}

        private int idMon;
        private string tenMon;
        private float gia;
        private int idLoaiMonAn;
        private byte[] hinhMonAn;
        private int id;
        private string name;
        public int IdMon { get => idMon; set => idMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public float Gia { get => gia; set => gia = value; }
        public int IdLoaiMonAn { get => idLoaiMonAn; set => idLoaiMonAn = value; }
        public byte[] HinhMonAn { get => hinhMonAn; set => hinhMonAn = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Food()
        {

        }
        public Food(DataRow row)
        {
            this.IdMon = row.Field<int>("IdMon");
            this.TenMon = row.Field<string>("TenMon");
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.IdLoaiMonAn = row.Field<int>("idLoaiMonAn");
            this.HinhMonAn = row.Field<byte[]>("hinhMonAn");
            this.Id = row.Field<int>("id");
            this.Name = row.Field<string>("name");
        }
    }
}

