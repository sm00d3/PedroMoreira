using ErrorOr;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedroMoreira.API.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        protected readonly ILogger _logger;

        public ApiController(ILogger logger) { _logger = logger; }

        protected IActionResult Problem(List<Error> errors)
        {
            HttpContext.Items.TryAdd("Errors", errors);

            var firstError = errors.FirstOrDefault();

            var statusCode = firstError.Type switch
            {
                ErrorType.Conflict => StatusCodes.Status409Conflict,
                ErrorType.Validation => StatusCodes.Status400BadRequest,
                ErrorType.NotFound => StatusCodes.Status404NotFound,
                _ => StatusCodes.Status500InternalServerError,
            };

            return Problem(statusCode: statusCode, title: firstError.Description);
        }
    }
}
