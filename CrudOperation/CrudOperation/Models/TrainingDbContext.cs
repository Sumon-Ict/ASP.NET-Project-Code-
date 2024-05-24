using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Models
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext>options) :  base(options) { }

        public DbSet<Employee> Employees { get; set; }

    }
}
