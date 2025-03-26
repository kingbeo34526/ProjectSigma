using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DAL
//{
//    public class DataProvider
//    {
//        private static string connectionString = "Data Source = KhoaTran07\\KHOATA;Initial Catalog = PhongKham; Integrated Security = True";

//        // Thực thi câu lệnh SELECT, trả về DataTable
//        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
//        {
//            DataTable data = new DataTable();
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    if (parameters != null)
//                        command.Parameters.AddRange(parameters);

//                    SqlDataAdapter adapter = new SqlDataAdapter(command);
//                    adapter.Fill(data);
//                }
//            }
//            return data;
//        }

//        // Thực thi câu lệnh INSERT, UPDATE, DELETE, trả về số dòng bị ảnh hưởng
//        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    if (parameters != null)
//                        command.Parameters.AddRange(parameters);

//                    return command.ExecuteNonQuery();
//                }
//            }
//        }

//        // Thực thi câu lệnh SELECT trả về một giá trị đơn lẻ (vd: COUNT, SUM, MAX)
//        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    if (parameters != null)
//                        command.Parameters.AddRange(parameters);

//                    return command.ExecuteScalar();
//                }
//            }
//        }
//    }
//}

namespace DAL
{
    public class DataProvider
    {
        private static readonly string connectionString = "Data Source=Alex\\TRANANHKHOA;Initial Catalog=PhongKham;Integrated Security=True";

        // Thực thi câu lệnh SELECT, trả về DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        // Thực thi câu lệnh INSERT, UPDATE, DELETE, trả về số dòng bị ảnh hưởng
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery();
                }
            }
        }

        // Thực thi câu lệnh SELECT trả về một giá trị đơn lẻ (vd: COUNT, SUM, MAX)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteScalar();
                }
            }
        }
    }
}
