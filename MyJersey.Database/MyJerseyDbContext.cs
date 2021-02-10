using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyJersey.Entities;

namespace MyJersey.Database
{
    public class MyJerseyDbContext : DbContext
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
                new Jersey[]
                {
                    new Jersey("/messi"){Id=1}
                }

            );
        }
    }
}