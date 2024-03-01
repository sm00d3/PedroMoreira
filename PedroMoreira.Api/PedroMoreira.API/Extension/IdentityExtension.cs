using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Infrastructure.Persistence;
using System.Text;

namespace PedroMoreira.API.Extension
{
    public static class IdentityExtension
    {
        public static IServiceCollection AddIdentityAuth(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddIdentity<IdentityUser, IdentityRole>(identity =>
            {
                identity.Password.RequiredLength = 8;
                identity.Password.RequireLowercase = true;
                identity.Password.RequireUppercase = true;
                identity.Password.RequireDigit = true;
                identity.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<PostgresContext>()
                .AddDefaultTokenProviders();

            _ = service.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,

                    ValidAudience = configuration["JwtOptions:Audience"],
                    ValidIssuer = configuration["JwtOptions:Issuer"],
                    RequireExpirationTime = configuration.GetSection("JwtOptions").GetValue<bool>("HasExpirationTime"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtOptions:IssuerSigningKey"] ?? string.Empty)),
                };
            });

            return service;
        }
    }
}