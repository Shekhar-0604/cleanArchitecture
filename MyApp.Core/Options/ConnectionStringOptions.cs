using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Options
{
    public class ConnectionStringOptions
    {
		public const string SectionName = "ConnectionStrings";
		public string DatabaseConfig { get; set; } = null!;
	}
}
