using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedroMoreira.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ErrorController : ApiController
    {

        [HttpGet("/error")]
        public IActionResult Error()
        {
            //TODO: Add Logging
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            return Problem(statusCode: StatusCodes.Status500InternalServerError, title: "An error occurred during the process.");
        }
    }
}
