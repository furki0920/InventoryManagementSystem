using InventoryManagementSystem.Models;
using InventoryTracking.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem.DAL
{
    public class DeviceMovementRepository
    {
        public void AddMovement(DeviceMovement movement)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
INSERT INTO dbo.DeviceMovements
(
    DeviceId,
    MovementType,
    FromEmployeeId,
    ToEmployeeId,
    FromFacilityId,
    ToFacilityId,
    FromStatusId,
    ToStatusId,
    Description,
    MovementDate
)
VALUES
(
    @DeviceId,
    @MovementType,
    @FromEmployeeId,
    @ToEmployeeId,
    @FromFacilityId,
    @ToFacilityId,
    @FromStatusId,
    @ToStatusId,
    @Description,
    @MovementDate
);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DeviceId", movement.DeviceId);
                command.Parameters.AddWithValue("@MovementType", movement.MovementType);

                command.Parameters.AddWithValue("@FromEmployeeId",
                    (object)movement.FromEmployeeId ?? DBNull.Value);

                command.Parameters.AddWithValue("@ToEmployeeId",
                    (object)movement.ToEmployeeId ?? DBNull.Value);

                command.Parameters.AddWithValue("@FromFacilityId",
                    (object)movement.FromFacilityId ?? DBNull.Value);

                command.Parameters.AddWithValue("@ToFacilityId",
                    (object)movement.ToFacilityId ?? DBNull.Value);

                command.Parameters.AddWithValue("@FromStatusId",
                    (object)movement.FromStatusId ?? DBNull.Value);

                command.Parameters.AddWithValue("@ToStatusId",
                    (object)movement.ToStatusId ?? DBNull.Value);

                command.Parameters.AddWithValue("@Description",
                    (object)movement.Description ?? DBNull.Value);

                command.Parameters.AddWithValue("@MovementDate",
                    movement.MovementDate);

                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllMovements()
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    dm.Id,

    d.SerialNumber,

    dm.MovementType,

    fe.FullName AS FromEmployee,

    te.FullName AS ToEmployee,

    ff.Name AS FromFacility,

    tf.Name AS ToFacility,

    fs.Name AS FromStatus,

    ts.Name AS ToStatus,

    dm.MovementDate,

    dm.Description

FROM DeviceMovements dm

INNER JOIN Devices d
ON d.Id = dm.DeviceId

LEFT JOIN Employees fe
ON fe.Id = dm.FromEmployeeId

LEFT JOIN Employees te
ON te.Id = dm.ToEmployeeId

LEFT JOIN Facilities ff
ON ff.Id = dm.FromFacilityId

LEFT JOIN Facilities tf
ON tf.Id = dm.ToFacilityId

LEFT JOIN Statuses fs
ON fs.Id = dm.FromStatusId

LEFT JOIN Statuses ts
ON ts.Id = dm.ToStatusId

ORDER BY dm.Id DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public DataTable SearchMovements(string searchText)
        {
            using (SqlConnection connection = Helpers.Database.GetConnection())
            {
                connection.Open();

                string query = @"
SELECT
    dm.Id,

    d.SerialNumber,

    dm.MovementType,

    fe.FullName AS FromEmployee,

    te.FullName AS ToEmployee,

    ff.Name AS FromFacility,

    tf.Name AS ToFacility,

    fs.Name AS FromStatus,

    ts.Name AS ToStatus,

    dm.MovementDate,

    dm.Description

FROM DeviceMovements dm

INNER JOIN Devices d
ON d.Id = dm.DeviceId

LEFT JOIN Employees fe
ON fe.Id = dm.FromEmployeeId

LEFT JOIN Employees te
ON te.Id = dm.ToEmployeeId

LEFT JOIN Facilities ff
ON ff.Id = dm.FromFacilityId

LEFT JOIN Facilities tf
ON tf.Id = dm.ToFacilityId

LEFT JOIN Statuses fs
ON fs.Id = dm.FromStatusId

LEFT JOIN Statuses ts
ON ts.Id = dm.ToStatusId

WHERE
    d.SerialNumber LIKE @Search
    OR dm.MovementType LIKE @Search
    OR fe.FullName LIKE @Search
    OR te.FullName LIKE @Search
    OR ff.Name LIKE @Search
    OR tf.Name LIKE @Search
    OR fs.Name LIKE @Search
    OR ts.Name LIKE @Search

ORDER BY dm.Id DESC;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@Search",
                    "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }





    }
}