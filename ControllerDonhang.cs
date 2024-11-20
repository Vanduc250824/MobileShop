using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    internal class ControllerDonhang
    {
        private Connection conn;

        public ControllerDonhang(Connection conn)
        {
            this.conn = conn;
        }
        //gọi Tất
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
                    {
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
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi khi lấy đơn hàng: " + ex.Message);
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
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
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
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi khi xóa đơn hàng: " + ex.Message);
                    return false;
                }
            }
        }

        // Sửa đơn hàng
        public bool UpdateDonhang(int id, int khachhangid, int sanphamid, int soluong, DateTime ngaymua)
        {
            string query = "UPDATE Donhang SET khachhangid = @khachhangid, sanphamid = @sanphamid, soluong = @soluong, ngaymua = @ngaymua WHERE id = @id";
            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@khachhangid", khachhangid);
                        command.Parameters.AddWithValue("@sanphamid", sanphamid);
                        command.Parameters.AddWithValue("@soluong", soluong);
                        command.Parameters.AddWithValue("@ngaymua", ngaymua);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Lỗi khi sửa đơn hàng: " + ex.Message);
                    return false;
                }
            }
        }
        // Tìm kiếm
        public List<Donhang> SearchDonhang(int id)
        {
            List<Donhang> donhangs = new List<Donhang>();

            using (SqlConnection connection = conn.GetConnection())
            {
                string query = "SELECT * FROM Donhang WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

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

            return donhangs;
        }


        public class Donhang
        {
            public int Id { get; set; }
            public int Khachhangid { get; set; }
            public int Sanphamid { get; set; }
            public int Soluong { get; set; }
            public DateTime Ngaymua { get; set; }
        }
    }
}