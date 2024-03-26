
namespace PedroMoreira.Domain.Contract.Authentication
{
    public record RefreshToken
    (
        string Token,
        DateTime Expire
    );
}
