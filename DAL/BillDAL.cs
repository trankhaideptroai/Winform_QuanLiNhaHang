using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get
            {
                if (instance == null) instance = new BillDAL(); return BillDAL.instance;
            }
            private set
            {
                BillDAL.instance = value;
            }
        }
        private BillDAL() { }
        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT idHD, dateCheckIn, dateCheckOut, idTable, trangthai FROM dbo.HoaDon WHERE idTable = " + id + " AND trangthai = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IDHD;
            }
            return -1;
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.HoaDon SET trangthai = 1 WHERE idHD = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec sp_InsertBIll @idTable", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idHD) FROM dbo.HoaDon");
            }
            catch
            {
                return 1;
            }

        }
    }
}
