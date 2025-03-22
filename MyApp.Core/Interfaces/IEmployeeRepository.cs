using MyApp.Core.Entities;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
		Task<IEnumerable<EmployeeEntity>> GetEmployee();
		Task<EmployeeEntity> GetEmployeeByID(Guid id);
		Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity);
		Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity entity);
		Task<bool> DeleteEmployeeAsync(Guid id);
	}
}
