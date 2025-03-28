﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Options;

namespace MyApp.Core
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddCoreDI(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
			return services;
		}
	}
}
