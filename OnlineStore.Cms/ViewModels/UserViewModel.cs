using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Helpers;

namespace OnlineStore.Cms.ViewModels
{
    public class UserViewModel
    {
        public IReadOnlyList<UserDto>? Users { get; set; }
    }
}
