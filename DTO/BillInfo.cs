using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int idHD, int idMon, int soluong)
        {
            this.ID = id;
            this.IDHD = idHD;
            this.IDMon = idMon;
            this.SoLuong = soluong;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDHD = (int)row["idHD"];
            this.IDMon = (int)row["idMon"];
            this.SoLuong = (int)row["soluong"];
        }

        private int iD;
        private int idHD;
        private int idMon;
        private int soluong;

        public int ID { get => iD; set => iD = value; }
        public int IDHD { get => idHD; set => idHD = value; }
        public int IDMon { get => idMon; set => idMon = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
    }
}
