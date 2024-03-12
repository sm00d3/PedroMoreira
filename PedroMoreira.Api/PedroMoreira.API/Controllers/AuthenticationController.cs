using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PedroMoreira.Contracts.Authentication;
using PedroMoreira.Domain.Authentication.Entity;
using System.Net;

namespace PedroMoreira.API.Controllers
{
    [Route("/auth")]
    [ApiController]
    public class AuthenticationController : ApiController
    {
        private readonly SignInManager<User> _signInManager;

        AuthenticationController(ILogger<AuthenticationController> logger, SignInManager<User> signInManager) : base(logger)
        {
            _signInManager = signInManager;
        }

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

        [HttpGet("/signout")]
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
