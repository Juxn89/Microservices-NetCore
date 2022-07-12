using Catalog.Service.Queries;
using Catalog.Service.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryService _productQueryService;
        public ProductController(IProductQueryService productQueryService)
        {
            _productQueryService = productQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<ProductDTO>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;
            if (!string.IsNullOrEmpty(ids)) {
                products = ids.Split(',').Select(i => int.Parse(i));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDTO> Get(int id) { 
            return await _productQueryService.GetAsync(id);
        }
    }
}