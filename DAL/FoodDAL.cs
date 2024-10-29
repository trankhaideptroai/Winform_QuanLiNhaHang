using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return FoodDAL.instance; }
            private set { FoodDAL.instance = value; }
        }

        private FoodDAL() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM dbo.MonAn INNER JOIN dbo.LoaiMonAn ON dbo.MonAn.idLoaiMonAn = dbo.LoaiMonAn.id where dbo.MonAn.idLoaiMonAn = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = "EXEC GetfoodByName @tenmon ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {name});

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetAllMonAn()
        {
            List<Food> listMonAn = new List<Food>();

            string query = "SELECT * FROM dbo.MonAn INNER JOIN dbo.LoaiMonAn ON dbo.MonAn.idLoaiMonAn = dbo.LoaiMonAn.id";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Food monAn = new Food(row);
                listMonAn.Add(monAn);
            }

            return listMonAn;
        }
        public void AddMonAn(Food monAn)
        {
            string query = "EXEC Insert_MonAn @tenMon , @gia , @idLMA , @hinhanh";
            object[] parameters = new object[]
            {
            monAn.TenMon,
            monAn.Gia,
            monAn.IdLoaiMonAn,
            monAn.HinhMonAn ?? (object)DBNull.Value
            };

            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void UpdateMonAn(Food monAn)
        {
            string query = "EXEC Update_MonAn @id , @tenMon , @gia , @idLMA ";
            object[] parameters = new object[]
            {
                monAn.IdMon,
                monAn.TenMon,
                monAn.Gia,
                monAn.IdLoaiMonAn
                
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void UpdateMonAn2(Food monAn)
        {
            string query = "EXEC Update_MonAnHinh @id , @hinh ";
            object[] parameters = new object[]
            {
                monAn.IdMon,
                monAn.HinhMonAn ?? (object)DBNull.Value
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void RemoveMonAn(Food monAn)
        {
            string query = "EXEC Delete_MonAn @id ";
            object[] parameters = new object[]
            {
                monAn.IdMon
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public List<Food> Search_MonAN(string tenmon)
        {
            List<Food> listMonAn = new List<Food>();

            string query = "EXEC Search_Food @tenmon ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] {tenmon});

            foreach (DataRow row in dataTable.Rows)
            {
                Food monAn = new Food(row);
                listMonAn.Add(monAn);
            }

            return listMonAn;
        }


    }
}
