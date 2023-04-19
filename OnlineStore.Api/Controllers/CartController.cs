using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.BusinessLogic.Services;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Api.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public CartController(ICartService cartService, IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerCart>> GetCart(string id)
        {
            var cart = await _cartService.GetCartAsync(id);
            return Ok(cart ?? new CustomerCart(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerCart>> UpdateCart(CustomerCart cartDto)
        {
            var cart = _mapper.Map<CustomerCart>(cartDto);
            var updatedCart = await _cartService.UpdateCartAsync(cart);
            return Ok(updatedCart);
        }

        [HttpDelete]
        public async Task DeleteCartAsync(string id)
        {
            await _cartService.DeleteCartAsync(id);
        }
    }
}
