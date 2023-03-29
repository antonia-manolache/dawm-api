using dawm_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dawm_api
{
    public class AppDbContext:  DbContext
    {
        public class ApiContext : DbContext
        {
            protected override void OnConfiguring
           (DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "UserDb");
            }
            public DbSet<User> Users { get; set; }
            public DbSet<Post> Posts { get; set; }
        }
    }
}
