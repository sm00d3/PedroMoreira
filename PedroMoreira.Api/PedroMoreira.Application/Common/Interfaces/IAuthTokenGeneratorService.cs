using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Domain.Contract.Authentication;
using PedroMoreira.Domain.Entities.Members;

namespace PedroMoreira.Application.Common.Interfaces
{
    public interface IAuthTokenGeneratorService
    {

        Task<AuthToken> GetAuthToken(Member user, List<string> roles);

        Task<bool> ValidateToken(Member? user, AuthToken? token);

        Task<TokenValidationResult?> GetClaimsPrincipal(string token);
    }
}
