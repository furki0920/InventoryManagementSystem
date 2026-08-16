using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DAL
{
    public class BrandRepository
    {
      
        
        public DataTable GetAllBrands()
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM Brands
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }


        public void AddBrand(Brand brand)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
INSERT INTO Brands
(
    Name
)
VALUES
(
    @Name
);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", brand.Name);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateBrand(Brand brand)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Brands
SET
    Name = @Name,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", brand.Id);

                command.Parameters.AddWithValue("@Name", brand.Name);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteBrand(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Brands
SET
    IsActive = 0,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public Brand GetBrandById(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM dbo.Brands
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Brand brand = new Brand();

                    brand.Id = Convert.ToInt32(reader["Id"]);

                    brand.Name = reader["Name"].ToString();

                    brand.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    brand.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    if (reader["UpdatedDate"] != DBNull.Value)
                        brand.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);

                    return brand;
                }

                return null;
            }
        }

        public DataTable SearchBrands(string keyword)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM dbo.Brands
WHERE IsActive = 1
AND Name LIKE @Keyword
ORDER BY Name;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public bool BrandExists(string name)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Brands
WHERE Name = @Name
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public bool BrandExists(string name, int excludedId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM dbo.Brands
WHERE Name = @Name
AND Id <> @Id
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                command.Parameters.AddWithValue("@Id", excludedId);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public Brand GetDeletedBrand(string name)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM dbo.Brands
WHERE Name = @Name
AND IsActive = 0;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Brand brand = new Brand();

                    brand.Id = Convert.ToInt32(reader["Id"]);
                    brand.Name = reader["Name"].ToString();
                    brand.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    return brand;
                }

                return null;
            }
        }

        public void RestoreBrand(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Brands
SET
    IsActive = 1,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }









    }
}
