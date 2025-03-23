using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Command
{
    public record DeleteEmployeeCommand(Guid id): IRequest<bool>;

	public class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
		: IRequestHandler<DeleteEmployeeCommand, Boolean>
	{
		public async Task<Boolean> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
		{
			return await employeeRepository.DeleteEmployeeAsync(request.id);
		}
	}
}
