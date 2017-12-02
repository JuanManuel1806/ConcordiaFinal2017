using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Concordia.Datos
{
    public class OngContext : DbContext
    {
        public OngContext() : base("name=Concordia")
    
    {
        Database.SetInitializer(new OngInitializer());
    }
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<TipoDocumento> TiposDocumento { get; set;}
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
            .HasMany(u => u.Usuarios)
            .WithRequired(u => u.TipoDocumento)
            .HasForeignKey(u => u.IdTipoDocumento)
            .WillCascadeOnDelete(false);
        }
    }
}