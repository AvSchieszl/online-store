using AutoMapper;
using OnlineStore.DataAccess.Repositories;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BusinessLogic.Services
{
    internal class UserService : IUsersService
    {
        private readonly IRepository<User> _userRepo;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        //Get all users
        public async Task<IReadOnlyList<UserDto>> GetUsers()
        {
            var users = await _userRepo.ListAllAsync();
            return _mapper.Map<IReadOnlyList<User>, IReadOnlyList < UserDto >> (users);
        }
        //Get user by id
        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            return _mapper.Map<User, UserDto>(user);
        }
        //Create new user
        public async Task<UserDto> CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<UserDto, User>(userDto);

            user.IsDeleted = false;

            var createdUser = await _userRepo.AddAsync(user);
            await _userRepo.SaveChangesAsync();
            return _mapper.Map<User, UserDto>(createdUser);
        }
        //Update User
        public async Task<UserDto> UpdateUser(UserDto userDto)
        {
            var user = await _userRepo.GetByIdAsync(userDto.Id);

            _mapper.Map(userDto, user);
            _userRepo.Update(user);
            await _userRepo.SaveChangesAsync();
            return _mapper.Map<User, UserDto>(user);
        }
        public async Task<bool> DeleteUser(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if (user == null) return false;

            user.IsDeleted = true;
            _userRepo.Update(user);
            await _userRepo.SaveChangesAsync();
            return true;
        }
    }
}
