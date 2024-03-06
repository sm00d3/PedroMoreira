using PedroMoreira.Domain.Authentication.Entity;
using System.Security.Claims;

namespace PedroMoreira.Application.Common.Interfaces
{
    public interface IJwtTokenGen
    {
        Token GenerateJwtToken(User user, List<Claim> claims);
        Token? VerifyJwtRefreshToken(User user, Token token);
    }
}
