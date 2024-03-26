using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PedroMoreira.API.Controllers.Common;

namespace PedroMoreira.API.Controllers
{
    [Route("User")]
    public class UserController : ApiController
    {
        public UserController(
            ILogger logger, 
            ISender sender) 
            : base(logger, sender) {}

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserInformation(string id)
        {
            return Ok();
        }

        [Authorize]
        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile(string id)
        {
            return Ok();
        }

    }
}
