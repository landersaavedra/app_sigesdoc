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
    
    public partial class SubTupaRequest
    {
        public int id_sub_tupa { get; set; }
        public Nullable<int> id_tupa { get; set; }
        public string indice { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string activo { get; set; }
        public Nullable<int> indicador { get; set; }
    
        public virtual TupaRequest tupa { get; set; }
    }
}
