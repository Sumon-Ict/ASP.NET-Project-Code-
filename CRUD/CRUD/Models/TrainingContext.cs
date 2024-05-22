using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions <TrainingContext> options) : base(options) { }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        

    }

}
