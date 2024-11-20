using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MobileShop
{
    internal class ControllerDonhang
    {
        private readonly Connection conn;

        public ControllerDonhang(Connection conn)
        {
            this.conn = conn ?? throw new ArgumentNullException(nameof(conn), "Kết nối không được để trống");
        }

        // Lấy tất cả đơn hàng
        public List<Donhang> GetAllDonhangs()
        {
            List<Donhang> donhangList = new List<Donhang>();
            string query = "SELECT * FROM Donhang";

            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Donhang donhang = new Donhang
                            {
                                Id = reader.GetInt32(0),
                                Khachhangid = reader.GetInt32(1),
                                Sanphamid = reader.GetInt32(2),
                                Soluong = reader.GetInt32(3),
                                Ngaymua = reader.GetDateTime(4)
                            };
                            donhangList.Add(donhang);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy danh sách đơn hàng: " + ex.Message);
                }
            }

            return donhangList;
        }

        // Thêm đơn hàng
        public bool AddDonhang(int khachhangid, int sanphamid, int soluong, DateTime ngaymua)
        {
            string query = "INSERT INTO Donhang (khachhangid, sanphamid, soluong, ngaymua) VALUES (@khachhangid, @sanphamid, @soluong, @ngaymua)";

            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@khachhangid", khachhangid);
                        command.Parameters.AddWithValue("@sanphamid", sanphamid);
                        command.Parameters.AddWithValue("@soluong", soluong);
                        command.Parameters.AddWithValue("@ngaymua", ngaymua);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thêm đơn hàng: " + ex.Message);
                    return false;
                }
            }
        }

        // Xóa đơn hàng
        public bool DeleteDonhang(int id)
        {
            string query = "DELETE FROM Donhang WHERE id = @id";

            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi xóa đơn hàng: " + ex.Message);
                    return false;
                }
            }
        }

        // Sửa đơn hàng
        public bool UpdateDonhang(int id, int soluong, DateTime ngaymua)
        {
            string query = "UPDATE Donhang SET soluong = @soluong, ngaymua = @ngaymua WHERE id = @id";

            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@soluong", soluong);
                        command.Parameters.AddWithValue("@ngaymua", ngaymua);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi sửa đơn hàng: " + ex.Message);
                    return false;
                }
            }
        }

        // Tìm kiếm đơn hàng theo ID
        public List<Donhang> SearchDonhang(int id)
        {
            List<Donhang> donhangs = new List<Donhang>();
            string query = "SELECT * FROM Donhang WHERE id = @id";

            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Donhang donhang = new Donhang
                                {
                                    Id = reader.GetInt32(0),
                                    Khachhangid = reader.GetInt32(1),
                                    Sanphamid = reader.GetInt32(2),
                                    Soluong = reader.GetInt32(3),
                                    Ngaymua = reader.GetDateTime(4)
                                };
                                donhangs.Add(donhang);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tìm kiếm đơn hàng: " + ex.Message);
                }
            }

            return donhangs;
        }
    }
}
