using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer("Server=.;Database=TestCleanArchitecture;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
			}
			);
			return services;
		}
	}
}
