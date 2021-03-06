using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2WebAPI.Core.DTO;
using Week2WebAPI.Core.Interfaces;
using Week2WebAPI.Core.Models;

namespace Week2WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var productsList = await _uow.ProductRepository.GetAllAsync();
            var productListModel = _mapper.Map<List<ProductDTO>>(productsList);
            return productListModel;
        }

        public async Task<ProductDTO> GetProductAsync(Guid id)
        {
            var currentProduct = await _uow.ProductRepository.GetByIdAsync(id);
            if (currentProduct == null)
            {
                throw new Exception("Product not found.");
            }
            else
            {
                var currentProductModel = _mapper.Map<ProductDTO>(currentProduct);
                return currentProductModel;
            }
        }

        public async Task<ProductDTO> CreateProductAsync(ProductDTO newEntity)
        {
            var productModel = _mapper.Map<Product>(newEntity);
            await _uow.ProductRepository.CreateAsync(productModel);
            await _uow.SaveAsync();
            return newEntity;
        }
        public async Task<ProductDTO> UpdateProductAsync(ProductDTO entity)
        {
            var updateProduct = _mapper.Map<Product>(entity);
            await _uow.ProductRepository.UpdateAsync(updateProduct);
            await _uow.SaveAsync();
            return entity;
        }
        public async Task<ProductDTO> DeleteProductAsync(Guid id)
        {
            var product = await _uow.ProductRepository.GetByIdAsync(id);

            var productModel = _mapper.Map<ProductDTO>(product);

            await _uow.ProductRepository.DeleteAsync(product);
            await _uow.SaveAsync();

            return productModel;
        }
    }
}
