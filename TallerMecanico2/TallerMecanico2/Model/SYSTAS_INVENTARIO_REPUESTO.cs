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
    
    public partial class SYSTAS_INVENTARIO_REPUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTAS_INVENTARIO_REPUESTO()
        {
            this.SYSTAS_DETALLE_REPARACION = new HashSet<SYSTAS_DETALLE_REPARACION>();
        }
    
        public int ID_inventario { get; set; }
        public string nombre_pieza { get; set; }
        public Nullable<int> cantidad_pieza { get; set; }
        public Nullable<int> cantidad_disp { get; set; }
        public Nullable<double> precio_pieza { get; set; }
        public Nullable<bool> pieza_nueva { get; set; }
        public Nullable<bool> pieza_usada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_DETALLE_REPARACION> SYSTAS_DETALLE_REPARACION { get; set; }
    }
}
