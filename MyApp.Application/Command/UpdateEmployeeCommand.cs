﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Command
{
    public record UpdateEmployeeCommand(Guid id, EmployeeEntity Employee): IRequest<EmployeeEntity>;

	public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
		: IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {

		public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
		{
			return await employeeRepository.UpdateEmployeeAsync(request.id, request.Employee);
		}
	}

}
