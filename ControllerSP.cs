using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobileShop
{
    internal class ControllerSP
    {
        private Connection conn;

        // Constructor sử dụng Connection
        public ControllerSP(Connection conn)
        {
            this.conn = conn;
        }

        // Phương thức lấy tất cả sản phẩm
        public List<Sanpham> GetAll()
        {
            List<Sanpham> sanphamlist = new List<Sanpham>();

            string query = "SELECT * FROM Sanpham";  // Query lấy tất cả sản phẩm

            // Sử dụng SqlConnection trong khối using để đảm bảo kết nối được đóng sau khi sử dụng
            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();  // Mở kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thực thi truy vấn và đọc kết quả
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Đọc từng dòng và tạo đối tượng Sanpham
                                Sanpham sp = new Sanpham
                                {
                                    SanphamId = reader.GetInt32(0),  // Đọc ID sản phẩm
                                    TenSP = reader.GetString(1),     // Đọc tên sản phẩm
                                    Gia = reader.GetDecimal(2),      // Đọc giá sản phẩm, sử dụng GetDecimal
                                    HangSX = reader.GetString(3)     // Đọc hãng sản xuất
                                };

                                sanphamlist.Add(sp);  // Thêm sản phẩm vào danh sách
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    // Hiển thị lỗi nếu có sự cố với truy vấn
                    Console.WriteLine("Lỗi: " + e.Message);
                }
            }
            return sanphamlist;  // Trả về danh sách sản phẩm
        }
    }
}
