using Microsoft.EntityFrameworkCore;
using MyJersey.Entities;

namespace MyJersey.Database
{
    public sealed class MyJerseyDbContext : DbContext
    {
        public MyJerseyDbContext(DbContextOptions<MyJerseyDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Jersey> Jerseys { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jersey>().HasData(
                new Jersey { Id = 1, Name = "Messi" },
                new Jersey { Id = 2, Name = "Lewy" }
                );
        }
    }
}