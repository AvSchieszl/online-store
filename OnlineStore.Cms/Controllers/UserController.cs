using Microsoft.AspNetCore.Mvc;
using OnlineStore.BusinessLogic.Services;
using OnlineStore.Cms.ViewModels;

namespace OnlineStore.Cms.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // Get all Users
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _usersService.GetUsers();
            var viewModel = new UserViewModel { Users = users };

            return View("Index", viewModel);
        }

        // Get User Details
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var user = await _usersService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // Create User
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return View(userDto);
            }

            var createdUser = await _usersService.CreateUser(userDto);
            return RedirectToAction("Details", new { id = createdUser.Id });
        }

        // Edit User
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _usersService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, UserDto userDto)
        {
            if (id != userDto.Id) return BadRequest();

            var updatedUser = await _usersService.UpdateUser(userDto);
            if (updatedUser == null) return NotFound();

            return RedirectToAction("Details", new { id = updatedUser.Id });
        }

        // Delete User
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _usersService.DeleteUser(id);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}