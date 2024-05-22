using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions <TrainingContext> options) : base(options) { }


        public DbSet<Customer> Customer { get; set; }
        

    }

}
