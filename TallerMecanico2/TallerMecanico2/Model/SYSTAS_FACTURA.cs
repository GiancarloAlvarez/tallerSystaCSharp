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
    
    public partial class SYSTAS_FACTURA
    {
        public int ID_Factura { get; set; }
        public Nullable<System.DateTime> Fecha_Factura { get; set; }
        public int Cliente_id { get; set; }
        public int mecanico_id { get; set; }
        public int servicio_id { get; set; }
        public string repuestos_usados { get; set; }
        public Nullable<double> costo_servicio { get; set; }
        public Nullable<double> subtotal_piezas { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<int> Servicio_id1 { get; set; }
        public Nullable<int> mecanico_id1 { get; set; }
        public int clientes_id1 { get; set; }
        public int detalle_id { get; set; }
    
        public virtual SYSTAS_DETALLE_REPARACION SYSTAS_DETALLE_REPARACION { get; set; }
        public virtual SYSTAS_MECANICO SYSTAS_MECANICO { get; set; }
        public virtual SYSTAS_MECANICO SYSTAS_MECANICO1 { get; set; }
        public virtual SYSTAS_SERVICIO SYSTAS_SERVICIO { get; set; }
    }
}
