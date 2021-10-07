using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesiIdentity.Data.Mapping
{
    public partial class AspNetRolesMap
        : IEntityTypeConfiguration<StajProjesiIdentity.Data.Entities.AspNetRoles>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesiIdentity.Data.Entities.AspNetRoles> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetRoles", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NormalizedName)
                .HasColumnName("NormalizedName")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "AspNetRoles";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Name = "Name";
            public const string NormalizedName = "NormalizedName";
            public const string ConcurrencyStamp = "ConcurrencyStamp";
        }
        #endregion
    }
}
