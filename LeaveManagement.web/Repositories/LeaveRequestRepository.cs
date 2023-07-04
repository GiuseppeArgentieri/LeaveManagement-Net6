using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;

namespace LeaveManagement.web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
