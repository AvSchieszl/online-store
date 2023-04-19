using Microsoft.AspNetCore.Mvc;
using OnlineStore.BusinessLogic.Services;
using OnlineStore.Cms.ViewModels;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Specifications;
using System.Security;

namespace OnlineStore.Cms.Controllers
{
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

            var viewModel = new ProductViewModel { Products = products };

            if (products == null || products.Data.Count == 0)
            {
                return NotFound();
            }

            return View("Index", viewModel); //view, for cms
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Details(int id)
        {
            var product = await _productsService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        // Edit Product
        [HttpGet("Edit/{id}")]
        public async Task<ActionResult<ProductDto>> Edit(int id)
        {
            var product = await _productsService.GetProductById(id);
            var categories = await _productsService.GetProductCategories();

            if (product == null)
            {
                return NotFound();
            }
            ViewBag.Categories = categories;
            return View(product);
        }
        [HttpPost("Edit/{id}")]
        public async Task<ActionResult> Edit(int id, [FromForm] ProductDto productDto)
        {
            if (id != productDto.Id) return BadRequest();

            var updatedProduct = await _productsService.UpdateProduct(productDto);
            if (updatedProduct == null) return NotFound();

            return RedirectToAction("Details", new { id = updatedProduct.Id });
        }

        //Create Product
        //TODO: Add UserID as CreatedBy, after implementing authentication
        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewBag.Categories = _productsService.GetProductCategories();
            return View();
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return View(productDto);
            }

            var createdProduct = await _productsService.CreateProduct(productDto);

            return RedirectToAction("Details", new { id = createdProduct.Id });
        }

        // Soft delete Product
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _productsService.DeleteProduct(id);
            if (!deleted) return NotFound();

            return NoContent();
        }

    }
}
