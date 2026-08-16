using InventoryManagementSystem.Helpers;
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
    public class FacilityRepository
    {
        public DataTable GetAllFacilities()
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM Facilities
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public Facility GetFacilityById(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM Facilities
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Facility facility = new Facility();

                    facility.Id = Convert.ToInt32(reader["Id"]);
                    facility.Name = reader["Name"].ToString();
                    facility.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    return facility;
                }

                return null;
            }
        }

        public void AddFacility(Facility facility)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
INSERT INTO Facilities
(
    Name
)
VALUES
(
    @Name
);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", facility.Name);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateFacility(Facility facility)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Facilities
SET
    Name = @Name,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", facility.Id);

                command.Parameters.AddWithValue("@Name", facility.Name);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteFacility(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Facilities
SET
    IsActive = 0,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public DataTable SearchFacilities(string keyword)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM Facilities
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

        public bool FacilityExists(string name)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Facilities
WHERE Name = @Name
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public bool FacilityExists(string name, int excludedId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Facilities
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

        public Facility GetDeletedFacility(string name)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM Facilities
WHERE Name = @Name
AND IsActive = 0;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Facility facility = new Facility();

                    facility.Id = Convert.ToInt32(reader["Id"]);
                    facility.Name = reader["Name"].ToString();
                    facility.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    return facility;
                }

                return null;
            }
        }

        public void RestoreFacility(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Facilities
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
