using Microsoft.AspNetCore.Mvc;
using OnlineStore.BusinessLogic.Services;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Specifications;
using System.Security;

namespace OnlineStore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        //Get Products
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDto>>> Index([FromQuery] ProductSpecParams productParams)
        {
            var products = await _productsService.CountAsync(productParams);

            return Ok(products); //json data, for api
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Details(int id)
        {
            var product = await _productsService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<ProductCategory>>> GetCategories()
        {
            return Ok(await _productsService.GetProductCategories());
        } 

    }
}
