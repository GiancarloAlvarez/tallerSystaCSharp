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
    
    public partial class SYSTAS_CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTAS_CLIENTES()
        {
            this.SYSTAS_VEHICULO = new HashSet<SYSTAS_VEHICULO>();
            this.SYSTAS_DETALLE_REPARACION = new HashSet<SYSTAS_DETALLE_REPARACION>();
            this.SYSTAS_FACTURA = new HashSet<SYSTAS_FACTURA>();
        }
    
        public int ID_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string cedula { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> telefono_Cliente { get; set; }
        public int Vehiculo_id1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_VEHICULO> SYSTAS_VEHICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_DETALLE_REPARACION> SYSTAS_DETALLE_REPARACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_FACTURA> SYSTAS_FACTURA { get; set; }
    }
}
