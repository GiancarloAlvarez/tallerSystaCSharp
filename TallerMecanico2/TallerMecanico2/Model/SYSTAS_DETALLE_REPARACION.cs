//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TallerMecanico2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSTAS_DETALLE_REPARACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTAS_DETALLE_REPARACION()
        {
            this.SYSTAS_FACTURA = new HashSet<SYSTAS_FACTURA>();
        }
    
        public int ID_Detalle { get; set; }
        public string Estado_Vehiculo { get; set; }
        public string Piezas_usadas { get; set; }
        public string mecanico_asignado { get; set; }
        public Nullable<double> mano_obra { get; set; }
        public Nullable<double> precio_piezas { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<int> mecanico_id { get; set; }
        public int clientes_id { get; set; }
        public int Inventario_id { get; set; }
    
        public virtual SYSTAS_CLIENTES SYSTAS_CLIENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_FACTURA> SYSTAS_FACTURA { get; set; }
        public virtual SYSTAS_INVENTARIO_REPUESTO SYSTAS_INVENTARIO_REPUESTO { get; set; }
        public virtual SYSTAS_MECANICO SYSTAS_MECANICO { get; set; }
    }
}
