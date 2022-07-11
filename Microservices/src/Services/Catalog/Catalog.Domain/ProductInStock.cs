using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Domain
{
    public class ProductInStock
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
