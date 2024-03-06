using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Application.Common.Interfaces;
using PedroMoreira.Domain.Authentication.Entity;
using PedroMoreira.Domain.Authentication.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PedroMoreira.Infrastructure.Authentication
{
    public class JwtTokenGen : IJwtTokenGen
    {
        private readonly JwtOptions _config;
        private readonly TokenValidationParameters _JwtParams;

        public JwtTokenGen(
            IOptions<JwtOptions> config, 
            TokenValidationParameters JwtParams)
        {
            this._config = config.Value;
            this._JwtParams = JwtParams;
        }

        public Token GenerateJwtToken(User user, List<Claim> claims)
        {
            var siginingCreds = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.IssuerSigningKey)),
                SecurityAlgorithms.HmacSha256
            );

            var ExpireDate = DateTime.Now.AddMinutes(Convert.ToDouble(_config.ExpirationTime));

            var secToken = new JwtSecurityToken(
                issuer: _config.Issuer,
                audience: _config.Audience,
                claims: claims,
                expires: ExpireDate,
                signingCredentials: siginingCreds
            );

            var token = new Token {
                JwtToken = new JwtSecurityTokenHandler().WriteToken(secToken),
                JwtTokenExpitre = ExpireDate
            };

            this.GenerateJwtRefreshToken(ref token);

            return token;
        }

        public Token? VerifyJwtRefreshToken(User? user, Token? token)
        {
            if (user is null || token is null)
                return null;

            var principal = this.ExtractClaimsPrincipal(token?.JwtToken);

            // TODO: Change the return of NULL to ErrorOr
            if (principal?.Identity?.Name is null || user?.RefreshToken != token?.RefreshToken || user?.RefreshTokenExpires < DateTime.UtcNow )
                return null;

            return this.GenerateJwtToken(user, principal.Claims.ToList());
        }

        private void GenerateJwtRefreshToken(ref Token token)
        {
            var randomNumber = new byte[64];
            using var generator = RandomNumberGenerator.Create();

            generator.GetBytes(randomNumber);
            token.RefreshToken = Convert.ToBase64String(randomNumber);
            token.RefreshTokenExpire = token.JwtTokenExpitre?.AddMinutes(this._config.RefreshTokenExpire);
        }

        private ClaimsPrincipal? ExtractClaimsPrincipal(string? Token)
        {
            return new JwtSecurityTokenHandler().ValidateToken(Token, this._JwtParams, out _);
        }

    }
}
