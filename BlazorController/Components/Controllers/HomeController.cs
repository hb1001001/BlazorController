using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace BlazorController.Components.Controllers
{
    [Route("api/SignUp")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return Ok("The controller works!");
        }
    }
}
