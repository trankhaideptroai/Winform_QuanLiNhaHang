using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        //public Table(int maban, string tenban, string trangthai)
        //{
        //    this.MaBan = maban;
        //    this.TenBan = tenban;
        //    this.TrangThai = trangthai;
        //}
        public Table()
        {

        }
        public Table(DataRow row)
        {
            this.MaBan = (int)row["maban"];
            this.TenBan = row["tenban"].ToString();
            this.TrangThai = row["trangthai"].ToString();
        }

        private int maban;
        private string tenban;
        private string trangthai;

        public int MaBan { get => maban; set => maban = value; }
        public string TenBan { get => tenban; set => tenban = value; }
        public string TrangThai { get => trangthai; set => trangthai = value; }
    }
}
