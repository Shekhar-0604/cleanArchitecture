using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApp.Core.Interfaces;
using MyApp.Core.Options;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>((provider, options) =>
			{
				options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DatabaseConfig);
			}
			);

			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			return services;
		}
	}
}
