using LeaveManagement.web.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.web.Models
{
	public class EmployeeAllocationVM : EmployeeListVM
	{
		public List<LeaveAllocationVM> LeaveAllocations { get; set; }
	}
}
