using System;
using System.Data.SqlClient;

namespace MobileShop
{
    internal class Connection
    {
        private string connectionString = "Data Source=VAN_DUC25\\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
