using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public Bill(int idhd, DateTime? dateCheckin, DateTime? dateCheckOut, int trangthai)
        {
            this.IDHD = idhd;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Trangthai = trangthai;
        }
        public Bill(DataRow row)
        {
            this.IDHD = (int)row["idHD"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }

            this.Trangthai = (int)row["trangthai"];
        }
        private int iDHD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int trangthai;

        public int IDHD { get => iDHD; set => iDHD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
