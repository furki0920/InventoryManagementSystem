using System;

namespace InventoryTracking.Models
{
    public class DeviceMovement
    {
        public int Id { get; set; }

        public int DeviceId { get; set; }

        public string MovementType { get; set; }

        public int? FromEmployeeId { get; set; }
        public int? ToEmployeeId { get; set; }

        public int? FromFacilityId { get; set; }
        public int? ToFacilityId { get; set; }

        public int? FromStatusId { get; set; }
        public int? ToStatusId { get; set; }

        public string Description { get; set; }

        public DateTime MovementDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}