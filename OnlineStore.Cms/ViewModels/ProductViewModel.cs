using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Helpers;

namespace OnlineStore.Cms.ViewModels
{
    public class ProductViewModel
    {
        public Pagination<ProductDto>? Products { get; set; }
    }
}
