﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyJLSV7.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompanyJLSAEntities : DbContext
    {
        public CompanyJLSAEntities()
            : base("name=CompanyJLSAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<Detalletarjeta> Detalletarjeta { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Formapago> Formapago { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Plato> Plato { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
