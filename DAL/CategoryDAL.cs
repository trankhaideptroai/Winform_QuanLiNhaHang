using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return CategoryDAL.instance; }
            private set { CategoryDAL.instance = value; }
        }
        private CategoryDAL() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from LoaiMonAn";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public void AddCategory(Category cat)
        {
            string query = "EXEC Insert_LoaiMonAn @name ";
            object[] parameters = new object[]
            {
                cat.Name

            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public void RemoveCategory(Category cat)
        {
            string query = "EXEC Delete_LoaiMonAn @id ";
            object[] parameters = new object[]
            {
                cat.ID

            };
            DataProvider.Instance.ExecuteQuery(query, parameters );
        }
        public void UpdateCategory(Category cat)
        {
            string query = "EXEC Update_LoaiMonAn @id , @name";
            object[] parameters = new object[]
            {
                cat.ID,
                cat.Name

            };
            DataProvider.Instance.ExecuteQuery (query, parameters );
        }

        public List<Category> Search_LoaiMonAn(string ten)
        {
            List<Category> list = new List<Category>();

            string query = "EXEC Search_LoaiMonAn @tenLMA";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {ten});

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
    }
}
