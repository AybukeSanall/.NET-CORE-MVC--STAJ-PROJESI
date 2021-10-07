using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StajProjesi.Data
{
    public partial class StajProjesiContext : DbContext
    {
        public StajProjesiContext(DbContextOptions<StajProjesiContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetRoleClaims> AspNetRoleClaims { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetRoles> AspNetRoles { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetUserClaims> AspNetUserClaims { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetUserLogins> AspNetUserLogins { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetUserRoles> AspNetUserRoles { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<StajProjesiIdentity.Data.Entities.AspNetUserTokens> AspNetUserTokens { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetRoleClaimsMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetRolesMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetUserClaimsMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetUserLoginsMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetUserRolesMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetUsersMap());
            modelBuilder.ApplyConfiguration(new StajProjesiIdentity.Data.Mapping.AspNetUserTokensMap());
            #endregion
        }
    }
}
