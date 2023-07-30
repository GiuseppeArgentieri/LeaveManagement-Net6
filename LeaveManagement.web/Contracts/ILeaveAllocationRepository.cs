using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation (int leaveTypeId);
        Task<bool> AllocationeExists (string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string EmployeeId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string EmployeeId, int leaveTypeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
        

    }
}
