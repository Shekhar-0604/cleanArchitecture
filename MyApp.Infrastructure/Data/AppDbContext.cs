using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppContext> options) : DbContext(options)
    {
    }
} 
