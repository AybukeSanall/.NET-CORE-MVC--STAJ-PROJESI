using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesi.Data.Mapping
{
    public partial class IllerMap
        : IEntityTypeConfiguration<StajProjesi.Data.Entities.Iller>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesi.Data.Entities.Iller> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Iller", "dbo");

            // key
            builder.HasKey(t => t.İd);

            // properties
            builder.Property(t => t.İd)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Sehiradi)
                .HasColumnName("sehiradi")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Iller";
        }

        public struct Columns
        {
            public const string İd = "id";
            public const string Sehiradi = "sehiradi";
        }
        #endregion
    }
}
