using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Application.Common.Interfaces;
using PedroMoreira.Domain.Authentication.Entity;
using PedroMoreira.Infrastructure.Authentication;
using PedroMoreira.Infrastructure.Persistence;
using System.Text;

namespace PedroMoreira.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager config)
        {

            services.AddAuth(config);
            services.AddDbContext<PostgresContext>(o => o.UseNpgsql(config.GetConnectionString("PmDatabase")));

            services.AddSingleton<IJwtTokenGen, JwtTokenGen>();

            return services;
        }

        public static IServiceCollection AddAuth(this IServiceCollection services, IConfigurationManager config) 
        {
            var JwtValidationParams = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,

                // TODO: Ajustar isto Add Options pattern and e Add validação
                ValidAudience = config["JwtOptions:Audience"] ?? throw new InvalidOperationException("JWT Audience not Configured."),
                ValidIssuer = config["JwtOptions:Issuer"] ?? throw new InvalidOperationException("JWT Issuer not Configured."),
                RequireExpirationTime = config.GetSection("JwtOptions").GetValue<bool>("HasExpirationTime"),
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtOptions:IssuerSigningKey"] ?? throw new InvalidOperationException("JWT Secret not Configured."))),
                ValidateLifetime = false
            };

            services.AddSingleton(JwtValidationParams);


            services.AddIdentity<User, IdentityRole>(identity =>
            {
                identity.Password.RequiredLength = 8;
                identity.Password.RequireLowercase = true;
                identity.Password.RequireUppercase = true;
                identity.Password.RequireDigit = true;
                identity.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<PostgresContext>()
              .AddDefaultTokenProviders();

            services.AddAuthentication( o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer( o =>
            {
                o.TokenValidationParameters = JwtValidationParams;
            });

            return services;
        }
    }
}
