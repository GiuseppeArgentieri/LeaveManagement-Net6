using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")] //puoi anche omettere questo attributo
        public LeaveType  LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int EmployeeId { get; set; }
    }
}
