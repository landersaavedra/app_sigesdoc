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
    
    public partial class ConsultaProtocolosAiResponse
    {
        public int id_protocolo { get; set; }
        public Nullable<int> id_seguimiento { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string evaluador { get; set; }
        public string activo { get; set; }
        public Nullable<int> id_est_pro { get; set; }
        public Nullable<int> id_protocolo_reemplaza { get; set; }
        public string ruta_pdf { get; set; }
    }
}
