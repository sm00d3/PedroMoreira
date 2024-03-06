using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Contracts.Authentication;

namespace PedroMoreira.API.Controllers
{
    [Route("/auth")]
    [ApiController]
    public class AuthenticationController : ApiController
    {

        [HttpGet("/signin")]
        public IActionResult Login(LoginRequest request)
        {
            return Ok("Nice") ;
        }

        [HttpPost("/signup")]
        public IActionResult Register(ResgisterRequest request)
        {
            return Ok("Nice");
        }
    }
}
