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
    
    public partial class SYSTAS_VEHICULO
    {
        public int ID_Vehiculo { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Nullable<int> Cliente_id { get; set; }
        public int FK_Cliente_id { get; set; }
    
        public virtual SYSTAS_CLIENTES SYSTAS_CLIENTES { get; set; }
    }
}