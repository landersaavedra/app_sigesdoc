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
    
    public partial class MAE_INFORME_INSPECCION_DSFPA
    {
        public int ID_INFORME_INSP { get; set; }
        public Nullable<int> ID_SOL_INS { get; set; }
        public string NOMBRE_INFORME { get; set; }
        public string USUARIO_CARGA { get; set; }
        public Nullable<int> USUARIO_OFICINA { get; set; }
        public Nullable<System.DateTime> FECHA_CARGA { get; set; }
        public string ACTIVO { get; set; }
        public string RUTA_PDF { get; set; }
        public string INSPECTOR { get; set; }
    
        public virtual MAE_SOLICITUD_INSPECCION MAE_SOLICITUD_INSPECCION { get; set; }
    }
}