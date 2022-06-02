using Microsoft.AspNetCore.Mvc;
using Week2WebAPI.Core.DTO;
using Week2WebAPI.Services;

namespace Week2WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAllProducts()
        {
            return await _productService.GetAllProductsAsync();
        }
        [HttpGet("{Id:Guid}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(Guid Id)
        {
            return await _productService.GetProductAsync(Id);
        }
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO newEntity)
        {
            return await _productService.CreateProductAsync(newEntity);
        }
        [HttpPut]
        public async Task<ActionResult<ProductDTO>> UpdateProduct(ProductDTO entity)
        {
            return await _productService.UpdateProductAsync(entity);
        }
        [HttpDelete("{Id:Guid}")]
        public async Task<ActionResult<ProductDTO>> DeleteProduct(Guid Id)
        {
            return await _productService.DeleteProductAsync(Id);
        }
    }
}
