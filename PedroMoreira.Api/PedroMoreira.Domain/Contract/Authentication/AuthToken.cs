using System.Text.Json;

namespace PedroMoreira.Domain.Contract.Authentication
{
    public record AuthToken(
        string TokenType,
        string Token,
        DateTime TokenExpire,
        RefreshToken RefreshToken);
}
