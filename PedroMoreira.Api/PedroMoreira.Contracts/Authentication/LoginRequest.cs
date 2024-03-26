namespace PedroMoreira.Contracts.Authentication
{
    public record LoginRequest(
        string Email,
        string Password,
        string? TwoFactorCode,
        string? TwoFactorRecoveryCode);
}
