using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Demo_API1.Model
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options):
            base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
    }
}
