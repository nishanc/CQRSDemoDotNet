using CQRSDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product { 
                Id = 1,
                ProductName = "Demo Product 1",
                Description = "Demo Product Description 1"
            },
            new Product { 
                Id = 2,
                ProductName = "Demo Product 2",
                Description = "Demo Product Description 2"
            },
            new Product { 
                Id = 3,
                ProductName = "Demo Product 3",
                Description = "Demo Product Description 3"
            });
        }
    }
}
