namespace Catalog.Services.Queries.DTOs
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductInStock Stock { get; set; }
    }
}