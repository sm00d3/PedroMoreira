using Microsoft.EntityFrameworkCore;
using PedroMoreira.Domain.Entities.Authentication;
using PedroMoreira.Domain.Entities.Members;
using PedroMoreira.Domain.Entities.Projects;

namespace PedroMoreira.Infrastructure.Persistence
{
    public class PostgresContext : DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) {}

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

            modelBuilder.Entity<Member>()
                .HasOne(MenPro => MenPro.Profile)
                .WithOne(memb => memb.User)
                .HasForeignKey<MemberProfile>(b => b.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Member>()
                .HasMany(Utok => Utok.UserTokens)
                .WithOne(memb => memb.Member)
                .HasForeignKey(forkey => forkey.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Member>()
                .HasMany(projSec => projSec.ProjectSecurity)
                .WithOne(memb => memb.Member)
                .HasForeignKey(forkey => forkey.MemberId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ProjectSecurity>()
                .HasOne(memb => memb.Member)
                .WithMany(projSec => projSec.ProjectSecurity)
                .HasForeignKey(forkey => forkey.MemberId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ProjectSecurity>()
                .HasOne(proj => proj.Project)
                .WithMany(projSec => projSec.ProjectSecurity)
                .HasForeignKey(forkey => forkey.ProjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ProjectSecurity>()
                .HasMany(claim => claim.Claims)
                .WithOne(projSec => projSec.ProjectSecurity)
                .HasForeignKey(forkey => forkey.ProjectSecurityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProjectSecurity>()
                .HasMany(roles => roles.Roles)
                .WithOne(proj => proj.ProjectSecurity)
                .HasForeignKey(forkey => forkey.ProjectSecurityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
                .HasMany(projeSec => projeSec.ProjectSecurity)
                .WithOne(proj => proj.Project)
                .HasForeignKey(forkey => forkey.ProjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }

    }

}