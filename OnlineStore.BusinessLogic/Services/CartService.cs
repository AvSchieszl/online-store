using AutoMapper;
using OnlineStore.DataAccess.Repositories;
using OnlineStore.Domain.Entities;

namespace OnlineStore.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartService(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task<CustomerCart> GetCartAsync(string cartId)
        {
            var cart = await _cartRepository.GetCartAsync(cartId);

            return cart ?? new CustomerCart(cartId);
        }

        public async Task<CustomerCart> UpdateCartAsync(CustomerCart cartDto)
        {
            var cart = _mapper.Map<CustomerCart>(cartDto);

            var updatedCart = await _cartRepository.UpdateCartAsync(cart);

            return updatedCart;
        }

        public async Task<bool> DeleteCartAsync(string cartId)
        {
            return await _cartRepository.DeleteCartAsync(cartId);
        }
    }
}
