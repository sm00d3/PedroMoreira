
namespace PedroMoreira.Contracts.Authentication
{
    public record AuthenticationResponse(
        string? JwtToken,
        DateTime? JwtTokenExpitre,
        string? RefreshToken,
        DateTime? RefreshTokenExpire
    );
}
