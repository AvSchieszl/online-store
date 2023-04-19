using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Helpers;
using OnlineStore.Domain.Specifications;

namespace OnlineStore.BusinessLogic.Services
{
    public interface IProductsService
    {
        Task<IReadOnlyList<ProductDto>> GetProducts(ISpecification<Product> spec);
        Task<ProductDto> GetProductById(int id);
        Task<Pagination<ProductDto>> CountAsync(ProductSpecParams productParams);
        Task<IReadOnlyList<ProductCategory>> GetProductCategories();
        Task<ProductDto> CreateProduct(ProductDto productDto);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int id);
    }
}