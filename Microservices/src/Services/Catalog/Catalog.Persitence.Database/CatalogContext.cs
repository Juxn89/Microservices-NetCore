using Catalog.Domain;
using Catalog.Persitence.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persitence.Database
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Catalog");
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder) {
            new ProductsConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}