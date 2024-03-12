using PedroMoreira.Domain.Authentication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Application.Services.Authentication.Common
{
    public record class AuthenticationResult(
        string Token,
        DateTime TokenExpiration,
        string RefreshToken,
        DateTime RefreshTokenTokenExpiration
    );
}
