using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesiIdentity.Data.Mapping
{
    public partial class AspNetRoleClaimsMap
        : IEntityTypeConfiguration<StajProjesiIdentity.Data.Entities.AspNetRoleClaims>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesiIdentity.Data.Entities.AspNetRoleClaims> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetRoleClaims", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.RoleAspNetRoles)
                .WithMany(t => t.RoleAspNetRoleClaims)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "AspNetRoleClaims";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string RoleId = "RoleId";
            public const string ClaimType = "ClaimType";
            public const string ClaimValue = "ClaimValue";
        }
        #endregion
    }
}
