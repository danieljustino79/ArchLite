using ArchLite.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArchLite.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(userService.GetUser());
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return Ok(userService.GetUsers());
        }
    }
}
