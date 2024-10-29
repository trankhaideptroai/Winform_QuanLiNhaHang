using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataProvider2
    {
        public static string connectionstr = "Data Source=DESKTOP-6P7HGD3;Initial Catalog=qlnhahang;Integrated Security=True";
        public DataTable ExcuteQuery(string querry)
        {
            DataTable data = new DataTable();
            using (SqlConnection connnection = new SqlConnection(connectionstr))
            {
                connnection.Open();
                SqlCommand command = new SqlCommand(querry, connnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(data);
                connnection.Close();

            }
            return data;
        }
        // using (SqlConnection conn = DataProvider.connect())
        public static SqlConnection connect()
        {
            return new SqlConnection(connectionstr);
        }
    }
}
