//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SYSTAS_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTAS_USUARIO()
        {
            this.SYSTAS_MECANICO = new HashSet<SYSTAS_MECANICO>();
        }
    
        public int ID_Usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Nullable<bool> EsAdmin { get; set; }
        public Nullable<bool> EsMecanic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTAS_MECANICO> SYSTAS_MECANICO { get; set; }
    }
}
