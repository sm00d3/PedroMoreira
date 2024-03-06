using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PedroMoreira.Domain.Authentication.Options;

namespace PedroMoreira.Domain
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddDomain(this IServiceCollection service, ConfigurationManager config)
        {
            service.Configure<JwtOptions>(config.GetSection(nameof(JwtOptions)));

            return service;
        }
    }
}
