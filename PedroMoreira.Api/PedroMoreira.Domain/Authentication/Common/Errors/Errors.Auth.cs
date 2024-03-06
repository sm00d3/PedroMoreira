using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Domain.Authentication.Common.Errors
{
    public static class Errors
    {
        public static class Auth
        {
            public static Error UnauthorizedToken =>
                Error.Forbidden(
                    "Auth.UnauthorizedToken", 
                    "Invalid Token."
                );
        }
    }
}
