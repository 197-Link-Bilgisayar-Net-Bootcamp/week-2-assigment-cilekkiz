using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2WebAPI.Core.DTO;

namespace Week2WebAPI.Services
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductAsync(Guid id);
        Task<ProductDTO> CreateProductAsync(ProductDTO newEntity);
        Task<ProductDTO> UpdateProductAsync(ProductDTO entity);
        Task<ProductDTO> DeleteProductAsync(Guid id);
    }
}
