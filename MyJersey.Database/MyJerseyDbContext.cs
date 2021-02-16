using System.Collections.Generic;
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
                new Jersey { Id = -1, Name = "Messi",TeamId = -1},
                new Jersey { Id = -2, Name = "Lewy",TeamId = -2}
                );
            modelBuilder.Entity<Photo>().HasData(
                new Photo() { Id = -1, Name = "MessiPrzod", JerseyId = -1},
                new Photo() { Id = -2, Name = "MessiTyl", JerseyId = -1 }
            );
            modelBuilder.Entity<Team>().HasData(
                new Team{ Id = -1, Name = "BVB" },
                new Team { Id = -2, Name = "Juve" }
            );
        }
    }
}