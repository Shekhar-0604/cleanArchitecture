using Microsoft.AspNetCore.Hosting;
using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.API
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddApplicationDI()
				.AddInfrastructureDI(configuration);
			
			return services;
		}
	}
}
