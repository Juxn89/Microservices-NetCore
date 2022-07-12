namespace Catalog.Service.Queries.DTOs
{
    public class ProductInStockDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
