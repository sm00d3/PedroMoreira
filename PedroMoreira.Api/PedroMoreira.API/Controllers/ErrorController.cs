using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedroMoreira.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ErrorController : ApiController
    {
        ErrorController(ILogger<ErrorController> logger) : base(logger) { }
        
        [HttpGet("/error")]
        public IActionResult Error()
        {
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            this._logger.LogError(exception?.Message, exception);

            return Problem(
                type: exception?.GetType().ToString(),
                statusCode: StatusCodes.Status500InternalServerError, 
                title: "An Internal error occurred during the process."
            );
        }
    }
}
