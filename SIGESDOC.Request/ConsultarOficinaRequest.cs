//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGESDOC.Request
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConsultarOficinaRequest
    {
        public int id_oficina { get; set; }
        public string nombre { get; set; }
        public Nullable<int> id_ofi_padre { get; set; }
        public string siglas { get; set; }
        public string ruc { get; set; }
    }
}
