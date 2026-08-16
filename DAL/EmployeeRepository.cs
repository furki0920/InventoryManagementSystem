using InventoryManagementSystem.Models;
using InventoryManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DAL
{
    public class EmployeeRepository
    {
        public DataTable GetAllEmployees()
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    FullName,
    Email
FROM Employees
WHERE IsActive = 1
ORDER BY FullName;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    FullName,
    Email,
    IsActive,
    CreatedDate,
    UpdatedDate
FROM Employees
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Employee employee = new Employee();

                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.FullName = reader["FullName"].ToString();

                    if (reader["Email"] != DBNull.Value)
                        employee.Email = reader["Email"].ToString();

                    employee.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    employee.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    if (reader["UpdatedDate"] != DBNull.Value)
                        employee.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);

                    return employee;
                }

                return null;
            }
        }

        public void AddEmployee(string fullName, string email)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
INSERT INTO Employees
(
    FullName,
    Email,
    IsActive,
    CreatedDate
)
VALUES
(
    @FullName,
    @Email,
    1,
    GETDATE()
);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FullName", fullName);

                if (string.IsNullOrEmpty(email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(int id, string fullName, string email)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Employees
SET
    FullName = @FullName,
    Email = @Email,
    UpdatedDate = GETDATE()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@FullName", fullName);

                if (string.IsNullOrEmpty(email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Employees
SET
    IsActive = 0,
    UpdatedDate = GETDATE()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public DataTable SearchEmployees(string searchText)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    FullName,
    Email
FROM Employees
WHERE IsActive = 1
AND
(
    FullName LIKE @SearchText
    OR Email LIKE @SearchText
)
ORDER BY FullName;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@SearchText",
                    "%" + searchText + "%"
                );

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public bool EmployeeExists(string fullName)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Employees
WHERE FullName = @FullName
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FullName", fullName);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public bool EmployeeExists(string fullName, int excludedId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Employees
WHERE FullName = @FullName
AND Id != @ExcludedId
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@ExcludedId", excludedId);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public bool EmployeeEmailExists(string email)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Employees
WHERE Email = @Email
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Email", email);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public bool EmployeeEmailExists(string email, int excludedId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Employees
WHERE Email = @Email
AND Id <> @ExcludedId
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ExcludedId", excludedId);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public Employee GetDeletedEmployee(string fullName)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    FullName,
    Email,
    IsActive,
    CreatedDate,
    UpdatedDate
FROM Employees
WHERE FullName = @FullName
AND IsActive = 0;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FullName", fullName);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Employee employee = new Employee();

                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.FullName = reader["FullName"].ToString();

                    if (reader["Email"] != DBNull.Value)
                        employee.Email = reader["Email"].ToString();

                    employee.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    employee.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    if (reader["UpdatedDate"] != DBNull.Value)
                        employee.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);

                    return employee;
                }

                return null;
            }
        }

        public void RestoreEmployee(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE Employees
SET
    IsActive = 1,
    UpdatedDate = GETDATE()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public bool HasAssignedDevices(int employeeId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM Devices
WHERE EmployeeId = @EmployeeId
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }








    }
}
