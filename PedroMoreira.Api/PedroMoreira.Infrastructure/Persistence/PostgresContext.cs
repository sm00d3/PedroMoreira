
using Microsoft.EntityFrameworkCore;
using PedroMoreira.Domain.Entities.Authentication;
using PedroMoreira.Domain.Entities.Members;
using PedroMoreira.Domain.Entities.Projects;
using PedroMoreira.Infrastructure.Persistence.Configurations;

namespace PedroMoreira.Infrastructure.Persistence
{
    public class PostgresContext : DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options){}

        public DbSet<Member> Member { get; set; }

        public DbSet<MemberProfile> UserProfile { get; set; }

        public DbSet<ProjectSecurity> ProjectSecurity { get; set; }

        public DbSet<MemberToken> MemberToken { get; set; }

        public DbSet<ProjectSecurityClaim> ProjectSecurityClaims { get; set; }

        public DbSet<ProjectSecurityRole> ProjectSecurityRole { get; set; }

        public DbSet<Project> Project { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(GetType().Assembly);

        }

    }

}