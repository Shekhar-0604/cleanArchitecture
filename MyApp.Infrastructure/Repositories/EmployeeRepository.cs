using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
	{
        public async Task<IEnumerable<EmployeeEntity>> GetEmployee()
        {
            return await dbContext.Employees.ToListAsync();
        }
		public async Task<EmployeeEntity> GetEmployeeByID(Guid id)
		{
			return await dbContext.Employees.FirstOrDefaultAsync(x =>x.Id == id);
		}
		public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity)
		{
			entity.Id = Guid.NewGuid();
			dbContext.Employees.Add(entity);
			await dbContext.SaveChangesAsync();
			return entity;
		}
		public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity entity)
		{
			var empDetails = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
			if (empDetails != null)
			{
				empDetails.Name = entity.Name;
				empDetails.Email = entity.Email;
				empDetails.Phone = entity.Phone;
				await dbContext.SaveChangesAsync();
				return empDetails;
			}
			return entity;
		}
		public async Task<bool> DeleteEmployeeAsync(Guid id)
		{
			var empDetails = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
			if(empDetails is not null)
			{
				dbContext.Remove(empDetails);
				await dbContext.SaveChangesAsync();
				return true;
			}
			return false;
		}
	}
}
