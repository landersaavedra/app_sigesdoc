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
    
    public partial class TipoLicenciaOperacionRequest
    {
        public int id_tipo_licencia_operacion { get; set; }
        public string nombre { get; set; }
        public string ruta_pdf { get; set; }
        public string activo { get; set; }
    
        public virtual List<ProtocoloLicenciaOperacionRequest> protocolo_licencia_operacion { get; set; }
    }
}
