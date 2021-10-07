using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajProjesi.Data.Mapping
{
    public partial class IlcelerMap
        : IEntityTypeConfiguration<StajProjesi.Data.Entities.Ilceler>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StajProjesi.Data.Entities.Ilceler> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Ilceler", "dbo");

            // key
            builder.HasKey(t => t.İd);

            // properties
            builder.Property(t => t.İd)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.İlceadi)
                .IsRequired()
                .HasColumnName("ilceadi")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Sehirid)
                .IsRequired()
                .HasColumnName("sehirid")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.SehiridIller)
                .WithMany(t => t.SehiridIlcelers)
                .HasForeignKey(d => d.Sehirid)
                .HasConstraintName("FK_Ilceler_Iller");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Ilceler";
        }

        public struct Columns
        {
            public const string İd = "id";
            public const string İlceadi = "ilceadi";
            public const string Sehirid = "sehirid";
        }
        #endregion
    }
}
