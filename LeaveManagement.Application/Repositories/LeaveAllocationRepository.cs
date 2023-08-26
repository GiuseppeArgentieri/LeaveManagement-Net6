using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IEmailSender emailSender;
        private readonly IMapper mapper;

		public LeaveAllocationRepository(
                ApplicationDbContext context,
                UserManager<Employee> userManager, 
                ILeaveTypeRepository leaveTypeRepository,
                AutoMapper.IConfigurationProvider configurationProvider,
                IEmailSender emailSender,
				IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.configurationProvider = configurationProvider;
            this.emailSender = emailSender;
            this.mapper = mapper;
		}

        public async Task<bool> AllocationeExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId &&
                                                              q.LeaveTypeId == leaveTypeId
                                                             && q.Period == period);
        }

		public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string EmployeeId)
		{
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == EmployeeId)
                .ProjectTo<LeaveAllocationVM>(configurationProvider)
                .ToListAsync();
            
            var employee = await userManager.FindByIdAsync(EmployeeId);
            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = allocations;
			
            return employeeAllocationModel;
		}

		public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
		{
			var allocation = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.FirstOrDefaultAsync(q => q.Id == id);

            if(allocation == null)
            {
                return null;
            }

			var employee = await userManager.FindByIdAsync(allocation.EmployeeId);
			var model = mapper.Map<LeaveAllocationEditVM>(allocation);
			model.Employee = mapper.Map<EmployeeListVM>(employee);

			return model;
		}

		public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            var EmployeesWithNewAllocations = new List<Employee>();

            foreach (var employee in employees)
            {
                if(await AllocationeExists(employee.Id, leaveTypeId, period))
                    { continue; }
                allocations.Add( new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
                EmployeesWithNewAllocations.Add(employee);
            }

            await AddRangeAsync(allocations);

            foreach (var employee in EmployeesWithNewAllocations) 
            {
                await emailSender.SendEmailAsync(employee.Email, $"Leave Allocation Posted for {period}", $"Your {leaveType.Name} " +
                    $"has been posted for the period of {period}. You have been given {leaveType.DefaultDays} days.");
            }

        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string EmployeeId, int leaveTypeId)
        {
            return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == EmployeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
