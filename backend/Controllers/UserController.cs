using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetUserNames()
        {
            string[] studentNames = new string[] { "Muyiwa", "Joshua", "Emmanuel", "Dayo" };
            return Ok(studentNames);
        }


    }
}