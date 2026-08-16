using System.Configuration;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Helpers
{
    public static class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}