using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedroMoreira.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpGet("/signin")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("/signup")]
        public async Task<ActionResult> Register()
        {
            return Ok();
        }
    }
}
