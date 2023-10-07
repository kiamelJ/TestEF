using Microsoft.EntityFrameworkCore;
using TestEF.Models;

namespace TestEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ship> Ships { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ship>().HasData(
                new Ship { Id = 1, Name = "Titanic", Capacity = 1000 },
                new Ship { Id = 2, Name = "Queen Mary", Capacity = 1500 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Coal", Weight = 500 },
                new Product { Id = 2, Name = "Gold", Weight = 1500 }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerId = 123, ShipId = 1 },
                new Order { Id = 2, CustomerId = 456, ShipId = 2 }
                );

        }
    }
}
