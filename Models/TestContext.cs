using Microsoft.EntityFrameworkCore;
using Test.Models.Entities;

namespace Test.Models
{
    class TestContext : DbContext
    {
        public DbSet<Groups> Groups { get; set; }

        public DbSet<Students> Students { get; set; }

        public TestContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=testappdb;Trusted_Connection=True;");
        }
    }
}
