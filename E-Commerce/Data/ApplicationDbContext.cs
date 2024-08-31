using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Coffe", Detail = "A Fresh coffe to build your day.", ImageUrl = "123.png", Price = 45000, IsTrending = true },
                new Product() { Id = 2, Name = "Capochino", Detail = "A Fresh Capochino to build your day.", ImageUrl = "123.png", Price = 55000, IsTrending = false },
                new Product() { Id = 3, Name = "Hot Chocolate", Detail = "A Fresh Hot chocolate to build your day.", ImageUrl = "123.png", Price = 60000, IsTrending = false },
                new Product() { Id = 4, Name = "Sperco", Detail = "A Fresh Sperco to build your day.", ImageUrl = "123.png", Price = 50000, IsTrending = true },
                new Product() { Id = 5, Name = "Ice Late", Detail = "A Fresh Ice late to build your day.", ImageUrl = "123.png", Price = 40000, IsTrending = false },
                new Product() { Id = 6, Name = "Americano", Detail = "A Fresh Americano to build your day.", ImageUrl = "123.png", Price = 70000, IsTrending = true },
                new Product() { Id = 7, Name = "Frapachino", Detail = "A Frapachino to build your day.", ImageUrl = "123.png", Price = 80000, IsTrending = false }
                );
        }
    }
}
