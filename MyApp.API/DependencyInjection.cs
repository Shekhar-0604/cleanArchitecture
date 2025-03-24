using Microsoft.AspNetCore.Hosting;
using MyApp.Application;
using MyApp.Infrastructure;
using MyApp.Core;

namespace MyApp.API
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddApplicationDI()
				.AddInfrastructureDI()
			.AddCoreDI(configuration);
			
			return services;
		}
	}
}
