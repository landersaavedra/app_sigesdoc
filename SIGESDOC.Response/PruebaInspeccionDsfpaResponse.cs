//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGESDOC.Response
{
    using System;
    using System.Collections.Generic;
    
    public partial class PruebaInspeccionDsfpaResponse
    {
        public int id_prueba_insp { get; set; }
        public Nullable<int> id_sol_ins { get; set; }
        public string usuario_carga { get; set; }
        public Nullable<int> usuario_oficina { get; set; }
        public Nullable<System.DateTime> fecha_carga { get; set; }
        public string activo { get; set; }
        public string ruta_pdf { get; set; }
        public string inspector { get; set; }
    
        public virtual SolicitudInspeccionResponse solicitud_inspeccion { get; set; }
    }
}
