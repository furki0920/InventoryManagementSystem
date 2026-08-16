using System;

namespace InventoryManagementSystem.Models
{
    public class Device
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public int MaterialTypeId { get; set; }

        public int? EmployeeId { get; set; }

        public int FacilityId { get; set; }

        public int StatusId { get; set; }

        public string DeviceModel { get; set; }

        public string Cpu { get; set; }

        public string Ram { get; set; }

        public string DiskSize { get; set; }

        public string SerialNumber { get; set; }

        public DateTime? ActivationDate { get; set; }

        public DateTime? AssignmentDate { get; set; }

        public string EstimatedLife { get; set; }

        public string Notes { get; set; }
    }
}