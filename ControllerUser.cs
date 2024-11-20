using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    internal class ControllerUser
    {
        private Connection conn;

        public ControllerUser(Connection _conn)
        {
            this.conn = _conn;
        }
        public List<User> GetAll()
        {
            List<User> customers = new List<User>();

            using (SqlConnection connection = conn.GetConnection())
            {
                string query = "SELECT * FROM Khachhang"; // Truy vấn lấy tất cả khách hàng từ bảng Khachhang

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tạo đối tượng Khachhang từ dữ liệu đọc được từ cơ sở dữ liệu
                                User customer = new User
                                {
                                    KhachhangId = reader.GetInt32(0),
                                    Ten = reader.GetString(1),
                                    Diachi = reader.GetString(2),
                                    Sdt = reader.GetString(3)
                                };

                                // Thêm khách hàng vào danh sách
                                customers.Add(customer);
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Lỗi: " + e.Message);
                }
            }

            return customers; // Trả về danh sách khách hàng
        }
        
    }
}
