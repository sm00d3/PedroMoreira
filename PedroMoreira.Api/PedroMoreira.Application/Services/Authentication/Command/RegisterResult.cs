namespace PedroMoreira.Application.Services.Authentication.Command
{
    public record RegisterResult(
        string Email,
        bool Succeeded
    );
}
