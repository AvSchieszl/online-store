using AutoMapper;
using OnlineStore.DataAccess.Repositories;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Helpers;
using OnlineStore.Domain.Specifications;

namespace OnlineStore.BusinessLogic.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IRepository<Product> _productRepo;
        private readonly IRepository<ProductCategory> _productCategoryRepo;
        private readonly IMapper _mapper;

        public ProductsService(IRepository<Product> productRepo, IRepository<ProductCategory> productCategory, IMapper mapper)
        {
            _productRepo = productRepo;
            _productCategoryRepo = productCategory;
            _mapper = mapper;
        }

        //Get all products
        public async Task<IReadOnlyList<ProductDto>> GetProducts(ISpecification<Product> spec)
        {
            var products = await _productRepo.ListAsync(spec);

            return _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDto>>(products);
        }

        //Get product by id
        public async Task<ProductDto> GetProductById(int id)
        {
            var spec = new ProductsFilterAndSortingSpecification(id);

            var product = await _productRepo.GetEntityWithSpec(spec);

            return _mapper.Map<Product, ProductDto>(product);
        }

        //Create new product
        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            var product = _mapper.Map<ProductDto, Product>(productDto);

            //Set properties on creation
            product.IsDeleted = false;
            // Set the CreatedById field to 2 (hard-coded), TODO Delete and replace with get id from logged-in user
            product.CreatedById = 2;
            // Set the CreatedAt field to the current date and time
            product.CreatedAt = DateTime.Now;

            var createdProduct = await _productRepo.AddAsync(product);
            await _productRepo.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(createdProduct);
        }

        //Update product
        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            var product = await _productRepo.GetByIdAsync(productDto.Id);

            _mapper.Map(productDto, product);
            _productRepo.Update(product);
            await _productRepo.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
        }

        //Soft delete product
        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return false;

            product.IsDeleted = true;
            _productRepo.Update(product);
            await _productRepo.SaveChangesAsync();
            return true;
        }

        public async Task<Pagination<ProductDto>> CountAsync(ProductSpecParams productParams)
        {
            var spec = new ProductsFilterAndSortingSpecification(productParams);
            var countSpec = new ProductCountSpecification(productParams);

            var totalItems = await _productRepo.CountAsync(countSpec);
            var products = await _productRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDto>>(products);

            return new Pagination<ProductDto>(
                productParams.PageIndex,
                productParams.PageSize,
                totalItems,
                data);
        }

        public async Task<IReadOnlyList<ProductCategory>> GetProductCategories()
        {
            return await _productCategoryRepo.ListAllAsync();
        }
    }
}