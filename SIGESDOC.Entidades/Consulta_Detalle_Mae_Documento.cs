//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGESDOC.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consulta_Detalle_Mae_Documento
    {
        public string NOMBRES { get; set; }
        public int ID_DOCUMENTO { get; set; }
        public int OFICINA_DESTINO { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<int> ID_CAB_DET_DOCUMENTO { get; set; }
        public int OFICINA_CREA { get; set; }
        public Nullable<bool> FLAG_DESTINO_PRINCIPAL { get; set; }
        public Nullable<int> NUMERO_DOCUMENTO { get; set; }
        public string NOM_DOC { get; set; }
        public string ASUNTO { get; set; }
    }
}