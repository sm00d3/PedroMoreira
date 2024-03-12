using ErrorOr;
using MediatR;
using PedroMoreira.Application.Services.Authentication.Common;

namespace PedroMoreira.Application.Services.Authentication.Command
{
    public class RegisterCommandHandler : 
        IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        public Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
             
            throw new NotImplementedException();
        }
    }
}
