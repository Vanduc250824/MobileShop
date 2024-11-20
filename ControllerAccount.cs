using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MobileShop
{
    internal class ControllerAccount
    {
        private Connection conn;

        public ControllerAccount() {
            this.conn = new Connection();
        }
        public bool CheckAccount(String tk, String mk)
        {
            String queryCheck = "SELECT COUNT(*) FROM Nguoidung WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau";
            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryCheck, connection))
                    {
                        command.Parameters.AddWithValue("@tendangnhap", tk);
                        command.Parameters.AddWithValue("@matkhau", mk);

                        int count = (int) command.ExecuteScalar();
                        return count > 0;
                        
                    }
                } catch (SqlException e)
                {
                    Console.WriteLine("Lỗi: " + e.Message);
                    return false;
                }
                connection.Close();
            }
            return false;
        }
    }
}
