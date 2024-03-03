using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PedroMoreira.Infrastructure.Persistence;
using System.Text;

namespace PedroMoreira.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager config)
        {

            services.AddDbContext<PostgresContext>(o => o.UseNpgsql(config.GetConnectionString("PmDatabase")));

            services.AddAuth(config);

            return services;
        }

        public static IServiceCollection AddAuth(this IServiceCollection services, IConfigurationManager config) 
        {
            services.AddIdentity<IdentityUser, IdentityRole>(identity =>
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
                o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,

                    ValidAudience = config["JwtOptions:Audience"],
                    ValidIssuer = config["JwtOptions:Issuer"],
                    RequireExpirationTime = config.GetSection("JwtOptions").GetValue<bool>("HasExpirationTime"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtOptions:IssuerSigningKey"]!)),
                };
            });

            return services;
        }
    }
}
