using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Domain.Authentication.Options
{
    public class JwtOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public bool HasExpirationTime { get; set; }
        public double ExpirationTime { get; set; }
        public string IssuerSigningKey { get; set; }
        public double RefreshTokenExpire { get; set; }
    }
}
