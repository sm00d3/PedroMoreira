﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PedroMoreira.Infrastructure.Persistence;

#nullable disable

namespace PedroMoreira.Infrastructure.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("ProjectId", "MemberId")
                        .IsUnique();

                    b.ToTable("ProjectSecurity");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurityClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProjectSecurityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProjectSecurityId");

                    b.ToTable("ProjectSecurityClaims");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProjectSecurityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectSecurityId");

                    b.ToTable("ProjectSecurityRole");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.MemberProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.MemberToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uuid");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberToken");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Projects.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurity", b =>
                {
                    b.HasOne("PedroMoreira.Domain.Entities.Members.Member", "Member")
                        .WithMany("ProjectSecurity")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PedroMoreira.Domain.Entities.Projects.Project", "Project")
                        .WithMany("ProjectSecurity")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurityClaim", b =>
                {
                    b.HasOne("PedroMoreira.Domain.Entities.Authentication.ProjectSecurity", "ProjectSecurity")
                        .WithMany("Claims")
                        .HasForeignKey("ProjectSecurityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectSecurity");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurityRole", b =>
                {
                    b.HasOne("PedroMoreira.Domain.Entities.Authentication.ProjectSecurity", "ProjectSecurity")
                        .WithMany("Roles")
                        .HasForeignKey("ProjectSecurityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectSecurity");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.MemberProfile", b =>
                {
                    b.HasOne("PedroMoreira.Domain.Entities.Members.Member", "User")
                        .WithOne("Profile")
                        .HasForeignKey("PedroMoreira.Domain.Entities.Members.MemberProfile", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.MemberToken", b =>
                {
                    b.HasOne("PedroMoreira.Domain.Entities.Members.Member", "Member")
                        .WithMany("UserTokens")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Authentication.ProjectSecurity", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Members.Member", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();

                    b.Navigation("ProjectSecurity");

                    b.Navigation("UserTokens");
                });

            modelBuilder.Entity("PedroMoreira.Domain.Entities.Projects.Project", b =>
                {
                    b.Navigation("ProjectSecurity");
                });
#pragma warning restore 612, 618
        }
    }
}