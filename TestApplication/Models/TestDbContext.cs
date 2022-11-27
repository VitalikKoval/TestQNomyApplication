using Microsoft.EntityFrameworkCore;

namespace TestApplication.Models
{
    public class TestDbContext : DbContext
    {
        public DbSet<QueueEntity> Users { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
