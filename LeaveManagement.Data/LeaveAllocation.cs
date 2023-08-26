using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")] //puoi anche omettere questo attributo
        public LeaveType  LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }
        public int Period { get; set; }
    }
}
