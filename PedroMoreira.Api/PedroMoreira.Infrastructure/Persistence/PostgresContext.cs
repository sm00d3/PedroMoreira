using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PedroMoreira.Domain.Authentication.Entity;

namespace PedroMoreira.Infrastructure.Persistence
{
    public class PostgresContext : IdentityDbContext
    {
        public PostgresContext(DbContextOptions options) : base(options) {}
        
        public DbSet<User> AppUser {  get; set; }

    }

}