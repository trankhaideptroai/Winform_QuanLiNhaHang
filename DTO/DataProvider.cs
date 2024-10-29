using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        private string connectionSTR = @"Data Source=DESKTOP-6P7HGD3;Initial Catalog=qlnhahang;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.StartsWith("@"))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.StartsWith("@"))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();
                }
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = null;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.StartsWith("@"))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();
                }
            }

            return data;
        }
    }
}