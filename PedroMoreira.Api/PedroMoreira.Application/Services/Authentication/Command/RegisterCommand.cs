using ErrorOr;
using MediatR;

namespace PedroMoreira.Application.Services.Authentication.Command
{
    public record RegisterCommand(
        string FirstName,
        string LastName,
        string Email,
        string Password) : IRequest<ErrorOr<RegisterResult>>;
}
