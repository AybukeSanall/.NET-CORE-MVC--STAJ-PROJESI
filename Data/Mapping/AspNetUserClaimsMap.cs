using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesiIdentity.Data.Mapping
{
    public partial class AspNetUserClaimsMap
        : IEntityTypeConfiguration<StajProjesiIdentity.Data.Entities.AspNetUserClaims>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesiIdentity.Data.Entities.AspNetUserClaims> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetUserClaims", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.UserAspNetUsers)
                .WithMany(t => t.UserAspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "AspNetUserClaims";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string UserId = "UserId";
            public const string ClaimType = "ClaimType";
            public const string ClaimValue = "ClaimValue";
        }
        #endregion
    }
}
