using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TableDAL
    {
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get { if (instance == null) instance = new TableDAL(); return TableDAL.instance; }
            private set { TableDAL.instance = value; }
        }
        public static int TableHeight = 100;
        public static int TableWidth = 100;
        private TableDAL() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC sp_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetTablebyId(int id)
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC GetNameTableByID @id", new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void Insert_BanAn(Table banAn)
        {
            string query = "EXEC Insert_BanAn @tenban , @trangthai ";
            object[] parameters = new object[]
            {
                banAn.TenBan,
                banAn.TrangThai
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void Update_BanAn(Table banAn)
        {
            string query = "EXEC Update_BanAn @maban , @tenban , @trangthai ";
            object[] parameters = new object[]
            {
                banAn.MaBan,
                banAn.TenBan,
                banAn.TrangThai

            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void Delete_BanAn(Table banAn)
        {
            string query = "EXEC Delete_BanAn @maban ";
            object[] parameters = new object[]
            {
                banAn.MaBan
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public List<Table> Search_BanAn(string ten)
        {
            
            List<Table> tablesearch = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC Search_BanAn @tenban", new object[] { ten });

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablesearch.Add(table);
            }
            return tablesearch;


        }
    }
}

