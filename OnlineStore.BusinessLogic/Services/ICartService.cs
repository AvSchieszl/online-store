using OnlineStore.Domain.Entities;

namespace OnlineStore.BusinessLogic.Services
{
    public interface ICartService
    {
        Task<CustomerCart> GetCartAsync(string cartId);
        Task<CustomerCart> UpdateCartAsync(CustomerCart cart);
        Task<bool> DeleteCartAsync(string cartId);
    }
}
