using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Command;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("addEmployee")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
		[HttpGet("getAllEmployee")]
		public async Task<IActionResult> GetAllEmployeeAsync()
		{
			var result = await sender.Send(new GetAllEmployeeQuery());
			return Ok(result);
		}
		[HttpGet("GetEmployeeByID/{employeeId}")]
		public async Task<IActionResult> GetEmployeeByIDAsync([FromRoute] Guid employeeId)
		{
			var result = await sender.Send(new GetEmployeeByIDQuery(employeeId));
			return Ok(result);
		}
		[HttpPut("updateEmployee")]
		public async Task<IActionResult> UpdateEmployeeAsync([FromBody] EmployeeEntity employee)
		{
			var result = await sender.Send(new UpdateEmployeeCommand(employee.Id, employee));
			return Ok(result);
		}

		[HttpDelete("GetEmployeeByID/{employeeId}")]
		public async Task<IActionResult> DeleteEmployeeByIDAsync([FromRoute] Guid employeeId)
		{
			var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
			return Ok(result);
		}

	}
}
