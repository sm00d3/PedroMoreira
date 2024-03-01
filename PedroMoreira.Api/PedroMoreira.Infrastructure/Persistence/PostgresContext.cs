using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PedroMoreira.Infrastructure.Persistence
{
    public class PostgresContext : IdentityDbContext
    {
        public PostgresContext(DbContextOptions options) : base(options)
        {
        }
    }
}