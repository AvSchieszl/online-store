using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Helpers;
using OnlineStore.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BusinessLogic.Services
{
    public interface IUsersService
    {
        Task<IReadOnlyList<UserDto>> GetUsers();
        Task<UserDto> GetUserById(int id);
        Task<UserDto> CreateUser(UserDto userDto);
        Task<UserDto> UpdateUser(UserDto userDto);
        Task<bool> DeleteUser(int id);
    }
}
