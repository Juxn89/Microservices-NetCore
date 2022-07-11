using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persitence.Database.Configuration
{
    public class ProductsConfiguration
    {
        public ProductsConfiguration(EntityTypeBuilder<Product> builder) {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);

            // Seed
            var products = new List<Product>();
            var stocks = new List<ProductInStock>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product {
                    Id = i,
                    Name = $"Product item name #{i}",
                    Description = $"Product item description #{i}",
                    Price = random.Next(100, 1000)
                });

                stocks.Add(new ProductInStock{
                    Id = i,
                    ProductId = i,
                    Stock = random.Next(0, 100),
                });
            }

            builder.HasData(products);
        }
    }
}
