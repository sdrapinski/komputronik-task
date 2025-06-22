using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace WebApi.Data
{
    public class KomputronikDbContext(DbContextOptions<KomputronikDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(10, 2);

            // Seed danych dla kategorii
            modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "Laptops" },
        new Category { Id = 2, Name = "Monitors" },
        new Category { Id = 3, Name = "Keyboards" },
        new Category { Id = 4, Name = "Mice" },
        new Category { Id = 5, Name = "Accessories" }
    );

            // Seed danych dla produktów
            modelBuilder.Entity<Product>().HasData(
       new Product { Id = 1, Name = "Dell XPS 13", Price = 4999.99m, CategoryId = 1, Description = "Good laptop" },
       new Product { Id = 2, Name = "Samsung 24\"", Price = 799.00m, CategoryId = 2, Description = "Good Monitor" },
       new Product { Id = 3, Name = "HP EliteBook 840", Price = 4299.00m, CategoryId = 1, Description = "Business laptop" },
       new Product { Id = 4, Name = "LG UltraFine 27\"", Price = 1999.99m, CategoryId = 2, Description = "High-resolution monitor" },
       new Product { Id = 5, Name = "Logitech MX Keys", Price = 399.99m, CategoryId = 3, Description = "Wireless keyboard" },
       new Product { Id = 6, Name = "Razer DeathAdder", Price = 249.00m, CategoryId = 4, Description = "Gaming mouse" },
       new Product { Id = 7, Name = "USB-C Hub", Price = 159.00m, CategoryId = 5, Description = "Expand your ports" },
       new Product { Id = 8, Name = "Apple Magic Keyboard", Price = 549.00m, CategoryId = 3, Description = "Apple keyboard" },
       new Product { Id = 9, Name = "Dell Wireless Mouse", Price = 99.00m, CategoryId = 4, Description = "Compact mouse" },
       new Product { Id = 10, Name = "Laptop Stand", Price = 129.00m, CategoryId = 5, Description = "Ergonomic accessory" }
   );
        }
    }
}
