﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TallerMecanico.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Systa_taller1Entities : DbContext
    {
        public Systa_taller1Entities()
            : base("name=Systa_taller1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SYSTAS_CLIENTES> SYSTAS_CLIENTES { get; set; }
        public virtual DbSet<SYSTAS_DETALLE_REPARACION> SYSTAS_DETALLE_REPARACION { get; set; }
        public virtual DbSet<SYSTAS_FACTURA> SYSTAS_FACTURA { get; set; }
        public virtual DbSet<SYSTAS_INVENTARIO_REPUESTO> SYSTAS_INVENTARIO_REPUESTO { get; set; }
        public virtual DbSet<SYSTAS_MECANICO> SYSTAS_MECANICO { get; set; }
        public virtual DbSet<SYSTAS_SERVICIO> SYSTAS_SERVICIO { get; set; }
        public virtual DbSet<SYSTAS_TALLER> SYSTAS_TALLER { get; set; }
        public virtual DbSet<SYSTAS_USUARIO> SYSTAS_USUARIO { get; set; }
        public virtual DbSet<SYSTAS_VEHICULO> SYSTAS_VEHICULO { get; set; }
    }
}
