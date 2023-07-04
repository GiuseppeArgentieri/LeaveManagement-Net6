using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Data
{
    public class LeaveRequest : BaseEntity
    {
        //non vogliamo questi 2 campi date nullable
        //non voglio che nessun records vada nelle tabelle senza questi fields
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }
        //employees requests and admins approvee
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        //when it is null it's in a pending state
        public bool Cancelled { get; set; }
        public int RequestingEmployeeId { get; set; }
    }
}
