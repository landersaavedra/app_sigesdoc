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
    
    public partial class MAE_DOCUMENTO_ANEXO
    {
        public int ID_DOCUMENTO_ANEXO { get; set; }
        public Nullable<int> ID_DOCUMENTO { get; set; }
        public string RUTA { get; set; }
        public string DESCRIPCION { get; set; }
        public string EXTENSION { get; set; }
        public string USUARIO_CREA { get; set; }
        public Nullable<System.DateTime> FECHA_CREA { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual MAE_DOCUMENTO MAE_DOCUMENTO { get; set; }
    }
}