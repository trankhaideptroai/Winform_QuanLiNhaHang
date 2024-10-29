using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;
        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return MenuDAL.instance; }
            private set { MenuDAL.instance = value; }
        }
        private MenuDAL() { }
        public List<Menu> GetListMenuBYTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.tenmon, bi.soluong, f.gia, f.gia * bi.soluong as totalPrice FROM dbo.HoaDonChiTiet as bi, dbo.HoaDon as b, dbo.MonAn as f \r\nWHERE bi.idHD = b.idHD AND b.TrangThai = 0 AND bi.IdMon = f.idMon AND b.idTable =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
