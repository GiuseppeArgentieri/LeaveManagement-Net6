using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;

namespace LeaveManagement.web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
