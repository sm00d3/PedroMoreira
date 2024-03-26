using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Authentication.BearerToken;

namespace PedroMoreira.Application.Services.Authentication.Query
{
    public record LoginQuery(
        string Email,
        string Password,
        string? TwoFactorCode,
        string? TwoFactorRecoveryCode) : IRequest<ErrorOr<AccessTokenResponse>>;
}
