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
    
    public partial class SP_CONSULTAR_DOC_X_OFICINA_X_TUPA_Result
    {
        public int id_documento { get; set; }
        public string anexos { get; set; }
        public System.DateTime fecha_envio { get; set; }
        public int numero { get; set; }
        public string hoja_tramite { get; set; }
        public string tipo_tramite { get; set; }
        public string documento { get; set; }
        public string asunto { get; set; }
        public string referencia { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public string externo { get; set; }
        public int ver_pdf { get; set; }
        public string editar { get; set; }
        public string clave { get; set; }
        public Nullable<int> id_tupa { get; set; }
        public string tupa { get; set; }
        public byte id_tipo_documento { get; set; }
        public Nullable<int> numero_documento { get; set; }
        public string nom_doc { get; set; }
        public string ruta_pdf { get; set; }
    }
}
