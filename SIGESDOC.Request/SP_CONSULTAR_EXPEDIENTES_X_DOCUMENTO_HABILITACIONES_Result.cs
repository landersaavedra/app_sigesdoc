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
    
    public partial class SP_CONSULTAR_EXPEDIENTES_X_DOCUMENTO_HABILITACIONES_Result
    {
        public int id_documento_seg { get; set; }
        public byte id_tipo_documento { get; set; }
        public Nullable<System.DateTime> fecha_crea { get; set; }
        public Nullable<System.DateTime> fecha_documento { get; set; }
        public string nombre_tipo_documento { get; set; }
        public string nombre_externo { get; set; }
        public string asunto { get; set; }
        public Nullable<int> num_documento { get; set; }
        public string nombre_documento { get; set; }
        public string evaluador { get; set; }
        public string expedientes { get; set; }
        public Nullable<System.DateTime> fecha_od { get; set; }
        public string codigo_habilitante { get; set; }
        public string ruta_pdf { get; set; }
        public string estado { get; set; }
        public string nom_oficina_crea { get; set; }
        public string usu_crea { get; set; }
    }
}
