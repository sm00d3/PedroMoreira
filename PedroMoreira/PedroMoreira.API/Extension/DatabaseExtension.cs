using Microsoft.EntityFrameworkCore;
using PedroMoreira.Infrastructure.Persistence;

namespace PedroMoreira.API.Extension
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostgresContext>(o => o.UseNpgsql(configuration.GetConnectionString("PmDatabase")));

            return services;
        }
    }
}