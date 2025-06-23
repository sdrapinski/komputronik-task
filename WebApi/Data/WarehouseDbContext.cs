using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace WebApi.Data
{
    public class WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Product => Set<Product>();
        public DbSet<Category> Category => Set<Category>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
           .Property(p => p.Price)
           .HasPrecision(18, 2);
        }
    }
}
