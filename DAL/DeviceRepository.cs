using InventoryManagementSystem.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem.DAL
{
    public class DeviceRepository
    {
        public DataTable GetAllDevices()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    d.Id,
    d.SerialNumber,
    b.Name AS Brand,
    d.DeviceModel,
    mt.Name AS MaterialType,
    e.FullName,
    f.Name AS Facility,
    s.Name AS Status
FROM dbo.Devices d
INNER JOIN dbo.Brands b ON d.BrandId = b.Id
INNER JOIN dbo.MaterialTypes mt ON d.MaterialTypeId = mt.Id
LEFT JOIN dbo.Employees e ON d.EmployeeId = e.Id
INNER JOIN dbo.Facilities f ON d.FacilityId = f.Id
INNER JOIN dbo.Statuses s ON d.StatusId = s.Id
WHERE d.IsActive = 1
ORDER BY d.Id;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable SearchDevices(string searchText)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    d.Id,
    d.SerialNumber,
    b.Name AS Brand,
    d.DeviceModel,
    mt.Name AS MaterialType,
    e.FullName,
    f.Name AS Facility,
    s.Name AS Status
FROM dbo.Devices d
INNER JOIN dbo.Brands b ON d.BrandId = b.Id
INNER JOIN dbo.MaterialTypes mt ON d.MaterialTypeId = mt.Id
LEFT JOIN dbo.Employees e ON d.EmployeeId = e.Id
INNER JOIN dbo.Facilities f ON d.FacilityId = f.Id
INNER JOIN dbo.Statuses s ON d.StatusId = s.Id
WHERE
    d.IsActive = 1
    AND
    (
        d.SerialNumber LIKE @Search
        OR b.Name LIKE @Search
        OR d.DeviceModel LIKE @Search
        OR mt.Name LIKE @Search
        OR e.FullName LIKE @Search
        OR f.Name LIKE @Search
        OR s.Name LIKE @Search
    )
ORDER BY d.Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetBrands()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM dbo.Brands
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetMaterialTypes()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM dbo.MaterialTypes
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetEmployees()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    FullName
FROM dbo.Employees
WHERE IsActive = 1
ORDER BY FullName;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetFacilities()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM dbo.Facilities
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetStatuses()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    Id,
    Name
FROM dbo.Statuses
WHERE IsActive = 1
ORDER BY Name;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(table);
            }

            return table;
        }

        public int AddDevice(Device device)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
INSERT INTO dbo.Devices
(
    MaterialTypeId,
    BrandId,
    EmployeeId,
    FacilityId,
    StatusId,
    DeviceModel,
    Cpu,
    Ram,
    DiskSize,
    SerialNumber,
    ActivationDate,
    AssignmentDate,
    EstimatedLife,
    Notes
)
VALUES
(
    @MaterialTypeId,
    @BrandId,
    @EmployeeId,
    @FacilityId,
    @StatusId,
    @DeviceModel,
    @Cpu,
    @Ram,
    @DiskSize,
    @SerialNumber,
    @ActivationDate,
    @AssignmentDate,
    @EstimatedLife,
    @Notes
);
SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaterialTypeId", device.MaterialTypeId);
                command.Parameters.AddWithValue("@BrandId", device.BrandId);

                if (device.EmployeeId.HasValue)
                    command.Parameters.AddWithValue("@EmployeeId", device.EmployeeId.Value);
                else
                    command.Parameters.AddWithValue("@EmployeeId", DBNull.Value);

                command.Parameters.AddWithValue("@FacilityId", device.FacilityId);
                command.Parameters.AddWithValue("@StatusId", device.StatusId);

                command.Parameters.AddWithValue("@DeviceModel", device.DeviceModel);
                command.Parameters.AddWithValue("@Cpu", device.Cpu);
                command.Parameters.AddWithValue("@Ram", device.Ram);
                command.Parameters.AddWithValue("@DiskSize", device.DiskSize);
                command.Parameters.AddWithValue("@SerialNumber", device.SerialNumber);
                command.Parameters.AddWithValue("@ActivationDate", device.ActivationDate);
                command.Parameters.AddWithValue("@AssignmentDate", device.AssignmentDate);
                command.Parameters.AddWithValue("@EstimatedLife", device.EstimatedLife);
                command.Parameters.AddWithValue("@Notes", device.Notes);

                try
                {
                    int newDeviceId = Convert.ToInt32(command.ExecuteScalar());

                    return newDeviceId;
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                    throw;
                }
            }
        }

        public Device GetDeviceById(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM dbo.Devices
WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Device device = new Device();

                    device.Id = Convert.ToInt32(reader["Id"]);

                    device.BrandId = Convert.ToInt32(reader["BrandId"]);

                    device.MaterialTypeId = Convert.ToInt32(reader["MaterialTypeId"]);

                    if (reader["EmployeeId"] != DBNull.Value)
                        device.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);

                    device.FacilityId = Convert.ToInt32(reader["FacilityId"]);

                    device.StatusId = Convert.ToInt32(reader["StatusId"]);

                    device.DeviceModel = reader["DeviceModel"].ToString();

                    device.Cpu = reader["Cpu"].ToString();

                    device.Ram = reader["Ram"].ToString();

                    device.DiskSize = reader["DiskSize"].ToString();

                    device.SerialNumber = reader["SerialNumber"].ToString();

                    if (reader["ActivationDate"] != DBNull.Value)
                        device.ActivationDate = Convert.ToDateTime(reader["ActivationDate"]);

                    if (reader["AssignmentDate"] != DBNull.Value)
                        device.AssignmentDate = Convert.ToDateTime(reader["AssignmentDate"]);

                    device.EstimatedLife = reader["EstimatedLife"].ToString();

                    device.Notes = reader["Notes"].ToString();

                    return device;
                }

                return null;
            }
        }

        public void UpdateDevice(Device device)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Devices
SET
    MaterialTypeId = @MaterialTypeId,
    BrandId = @BrandId,
    EmployeeId = @EmployeeId,
    FacilityId = @FacilityId,
    StatusId = @StatusId,
    DeviceModel = @DeviceModel,
    Cpu = @Cpu,
    Ram = @Ram,
    DiskSize = @DiskSize,
    SerialNumber = @SerialNumber,
    ActivationDate = @ActivationDate,
    AssignmentDate = @AssignmentDate,
    EstimatedLife = @EstimatedLife,
    Notes = @Notes,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", device.Id);
                command.Parameters.AddWithValue("@MaterialTypeId", device.MaterialTypeId);
                command.Parameters.AddWithValue("@BrandId", device.BrandId);

                if (device.EmployeeId.HasValue)
                    command.Parameters.AddWithValue("@EmployeeId", device.EmployeeId.Value);
                else
                    command.Parameters.AddWithValue("@EmployeeId", DBNull.Value);

                command.Parameters.AddWithValue("@FacilityId", device.FacilityId);
                command.Parameters.AddWithValue("@StatusId", device.StatusId);
                command.Parameters.AddWithValue("@DeviceModel", device.DeviceModel);
                command.Parameters.AddWithValue("@Cpu", device.Cpu);
                command.Parameters.AddWithValue("@Ram", device.Ram);
                command.Parameters.AddWithValue("@DiskSize", device.DiskSize);
                command.Parameters.AddWithValue("@SerialNumber", device.SerialNumber);
                command.Parameters.AddWithValue("@ActivationDate", device.ActivationDate);
                command.Parameters.AddWithValue("@AssignmentDate", device.AssignmentDate);
                command.Parameters.AddWithValue("@EstimatedLife", device.EstimatedLife);
                command.Parameters.AddWithValue("@Notes", device.Notes);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteDevice(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Devices
SET
    IsActive = 0,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public bool DeviceExists(string serialNumber)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT COUNT(*)
FROM dbo.Devices
WHERE SerialNumber = @SerialNumber
AND IsActive = 1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SerialNumber", serialNumber);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public Device GetDeletedDevice(string serialNumber)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT *
FROM dbo.Devices
WHERE SerialNumber = @SerialNumber
AND IsActive = 0;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SerialNumber", serialNumber);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Device device = new Device();

                    device.Id = Convert.ToInt32(reader["Id"]);
                    device.BrandId = Convert.ToInt32(reader["BrandId"]);
                    device.MaterialTypeId = Convert.ToInt32(reader["MaterialTypeId"]);

                    if (reader["EmployeeId"] != DBNull.Value)
                        device.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);

                    device.FacilityId = Convert.ToInt32(reader["FacilityId"]);
                    device.StatusId = Convert.ToInt32(reader["StatusId"]);
                    device.DeviceModel = reader["DeviceModel"].ToString();
                    device.Cpu = reader["Cpu"].ToString();
                    device.Ram = reader["Ram"].ToString();
                    device.DiskSize = reader["DiskSize"].ToString();
                    device.SerialNumber = reader["SerialNumber"].ToString();

                    if (reader["ActivationDate"] != DBNull.Value)
                        device.ActivationDate = Convert.ToDateTime(reader["ActivationDate"]);

                    if (reader["AssignmentDate"] != DBNull.Value)
                        device.AssignmentDate = Convert.ToDateTime(reader["AssignmentDate"]);

                    device.EstimatedLife = reader["EstimatedLife"].ToString();
                    device.Notes = reader["Notes"].ToString();

                    return device;
                }

                return null;
            }
        }

        public void RestoreDevice(int id)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
UPDATE dbo.Devices
SET
    IsActive = 1,
    UpdatedDate = SYSDATETIME()
WHERE Id = @Id;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public DataTable GetDevicesByEmployee(int employeeId)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    b.Name AS Brand,
    d.DeviceModel,
    d.SerialNumber,
    f.Name AS Facility,
    s.Name AS Status
FROM Devices d
INNER JOIN Brands b
ON d.BrandId = b.Id

INNER JOIN Facilities f
ON d.FacilityId = f.Id

INNER JOIN Statuses s
ON d.StatusId = s.Id

WHERE
    d.EmployeeId = @EmployeeId
AND d.IsActive = 1

ORDER BY b.Name, d.DeviceModel;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }



    }
}