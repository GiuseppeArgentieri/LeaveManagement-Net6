using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
	public class LeaveAllocationVM
	{
		[Required]
		public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(0,50, ErrorMessage = "invalid number entered")]
        public int NumberOfDays { get; set; }
        
        [Required]
		[Display(Name = "Allocation Period")]
		public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
        //never include a data model inside of a view model - that is an unkown
        //view models talks just to view models
    }
}
