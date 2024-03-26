using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using PedroMoreira.Domain.Authentication.Common.Errors;
using PedroMoreira.Domain.Entities.Members;

namespace PedroMoreira.Application.Services.Authentication.Command
{
    internal class RegisterCommandHandler : 
        IRequestHandler<RegisterCommand, ErrorOr<RegisterResult>>
    {

        private readonly UserManager<Member> _userManager;
        private readonly IUserStore<Member> _userStore;
        private readonly ILogger<RegisterCommandHandler> _logger;

        public RegisterCommandHandler(
            UserManager<Member> userManager,
            IUserStore<Member> userStore,
            ILogger<RegisterCommandHandler> logger)
        {
            _userManager = userManager;
            _userStore = userStore;
            _logger = logger;
        }

        public async Task<ErrorOr<RegisterResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            var emailStore = (IUserEmailStore<Member>)_userStore;

            Member? user = await emailStore.FindByEmailAsync(command.Email, cancellationToken);

            // Validar se o User já exist com aquele email
            if (user is null)
                return Errors.Authentication.InvalidEmail;

            // Create User
            var newUser = new Member();
            await _userStore.SetUserNameAsync(newUser, command.Email, cancellationToken);
            await emailStore.SetEmailAsync(newUser, command.Email, cancellationToken);

            // Create User Profile
            user.Profile = new MemberProfile
            {
                FirstName = command.FirstName,
                LastName = command.LastName
            };

            var result = await _userManager.CreateAsync(newUser, command.Password);

            if (!result.Succeeded) {

                return result.Errors.Select(a => Error.Validation(a.Code, a.Description)).ToList<Error>();
            }

            // TODO: Add send Email to Email User to verify account

            return new RegisterResult(command.Email, true);
        }
    }
}
