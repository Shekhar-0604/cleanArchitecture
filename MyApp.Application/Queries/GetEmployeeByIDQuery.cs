using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Queries
{
    public record GetEmployeeByIDQuery(Guid empId) : IRequest<EmployeeEntity>;

	public class GetEmployeeByIDQueryHandler(IEmployeeRepository employeeRepository)
		: IRequestHandler<GetEmployeeByIDQuery, EmployeeEntity>
	{
		public async Task<EmployeeEntity> Handle(GetEmployeeByIDQuery request, CancellationToken cancellationToken)
		{
			return await employeeRepository.GetEmployeeByID(request.empId);
			
		}
	}
}
