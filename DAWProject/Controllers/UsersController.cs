using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Models.DTOs;
using DAWProject.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserRequestDTO user)
        {
            var result = _userService.Authenticate(user);

            if(result == null)
            {
                return BadRequest(new { Message = "Username or Password is invalid!" });
            }
            return Ok(result);
        }
        
        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto dto)
        {
            _userService.Create(new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Username = dto.Username,
                Password = dto.Password
            });
            return Ok();
        }
    }
}
