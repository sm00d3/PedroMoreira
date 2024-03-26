using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using PedroMoreira.Application.Common.Interfaces;
using PedroMoreira.Domain.Authentication.Common.Errors;
using PedroMoreira.Domain.Entities.Members;

namespace PedroMoreira.Application.Services.Authentication.Query
{
    internal class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AccessTokenResponse>>
    {
        private readonly ILogger<LoginQueryHandler> _logger;
        private readonly SignInManager<Member> _signManager;
        private readonly UserManager<Member> _userManager;
        private readonly IAuthTokenGeneratorService _tokenGeneratorService;

        public LoginQueryHandler(
            ILogger<LoginQueryHandler> logger,
            UserManager<Member> userManager,
            SignInManager<Member> signManager,
            IAuthTokenGeneratorService tokenGeneratorService)
        {
            _logger = logger;
            _userManager = userManager;
            _signManager = signManager;
            _tokenGeneratorService = tokenGeneratorService;
        }

        public async Task<ErrorOr<AccessTokenResponse>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {

            //var user = await _userManager.Users.FirstOrDefaultAsync((u => u.Email == request.Email));

            //if (user is null)
            //    return Errors.Authentication.InvalidCredentials;

            //if(!(await _userManager.IsEmailConfirmedAsync(user)))
            //    return Errors.Authentication.EmailNotConfirmed;

            //var signIn = await _signManager.CheckPasswordSignInAsync(user, request.Password, true);

            //if(!signIn.Succeeded && signIn.IsNotAllowed)
            //{
            //    if (signIn.IsLockedOut)
            //        return new List<Error>
            //        { 
            //            Errors.Authentication.InvalidCredentials,
            //            Errors.Authentication.EmailNotConfirmed
            //        };

            //    return Errors.Authentication.InvalidCredentials;
            //}

            try
            {

                //var token = await _tokenGeneratorService.GetAuthToken(user, (await _userManager.GetRolesAsync(user)).ToList());

                //if (token is null)
                //    return Errors.Common.UnknownError;


                //Todo: Falta Gerar o Token.

                return new AccessTokenResponse
                {
                    AccessToken = string.Empty,
                    ExpiresIn = 1234,
                    RefreshToken = string.Empty
                };

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error While User {1} try to login see the exception to more details./n", new { ex });

                return Errors.Common.UnknownError;
            }                
        }
    }
}
