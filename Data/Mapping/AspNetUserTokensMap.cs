using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesiIdentity.Data.Mapping
{
    public partial class AspNetUserTokensMap
        : IEntityTypeConfiguration<StajProjesiIdentity.Data.Entities.AspNetUserTokens>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesiIdentity.Data.Entities.AspNetUserTokens> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetUserTokens", "dbo");

            // key
            builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            // properties
            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.LoginProvider)
                .IsRequired()
                .HasColumnName("LoginProvider")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.Value)
                .HasColumnName("Value")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.UserAspNetUsers)
                .WithMany(t => t.UserAspNetUserTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "AspNetUserTokens";
        }

        public struct Columns
        {
            public const string UserId = "UserId";
            public const string LoginProvider = "LoginProvider";
            public const string Name = "Name";
            public const string Value = "Value";
        }
        #endregion
    }
}
