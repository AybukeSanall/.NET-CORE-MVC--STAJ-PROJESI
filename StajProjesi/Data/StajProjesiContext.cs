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
        public virtual DbSet<StajProjesi.Data.Entities.Ilceler> Ilcelers { get; set; }

        public virtual DbSet<StajProjesi.Data.Entities.Iller> Illers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new StajProjesi.Data.Mapping.IlcelerMap());
            modelBuilder.ApplyConfiguration(new StajProjesi.Data.Mapping.IllerMap());
            #endregion
        }
    }
}
