using Catalog.Persitence.Database;
using Catalog.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;

namespace Catalog.Service.Queries
{
    public interface IProductQueryService {
        Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDTO> GetAsync(int id);
    }
    public class ProductQueryService : IProductQueryService
    {
        private readonly CatalogContext _context;
        public ProductQueryService(CatalogContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null) {
            var collection = await _context.Products
                    .Where(x => products == null || products.Contains(x.Id))
                    .OrderByDescending(x => x.Id)
                    .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductDTO>>();
        }

        public async Task<ProductDTO> GetAsync(int id) {
            return (await _context.Products.SingleAsync(x => x.Id == id)).MapTo<ProductDTO>();
        }
    }
}
