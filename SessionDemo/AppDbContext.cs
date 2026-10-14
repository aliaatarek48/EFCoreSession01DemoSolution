using Microsoft.EntityFrameworkCore;
using SessionDemo.Models;

namespace SessionDemo
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo;Trusted_Connection=True;TrustServerCertificate = true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
