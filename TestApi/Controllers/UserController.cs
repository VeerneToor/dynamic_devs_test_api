using Microsoft.AspNetCore.Mvc;
using TestApi.Services.UserServices;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_userService.GetUserById(5));
        }
    }
}
