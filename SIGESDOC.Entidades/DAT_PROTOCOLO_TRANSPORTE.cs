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
    
    public partial class DAT_PROTOCOLO_TRANSPORTE
    {
        public int ID_DAT_PRO_TRANSPORTE { get; set; }
        public Nullable<int> ID_PROTOCOLO { get; set; }
        public Nullable<int> NUMERO { get; set; }
        public Nullable<int> ANNO { get; set; }
        public Nullable<int> DIRECCION_LEGAL { get; set; }
        public Nullable<int> REPRESENTANTE_LEGAL { get; set; }
        public Nullable<int> ID_TIPO_CAMARA_TRANS { get; set; }
        public Nullable<int> ID_TRANSPORTE { get; set; }
        public string PLACA { get; set; }
        public string COD_HABILITACION { get; set; }
        public Nullable<int> ID_TIPO_CARROCERIA { get; set; }
        public Nullable<int> ID_UM { get; set; }
        public Nullable<decimal> CARGA_UTIL { get; set; }
        public string ACTA_INSPECCION { get; set; }
        public string INFORME_AUDITORIA { get; set; }
        public string INFORME_TECNICO_EVALUACION { get; set; }
        public string PERSONA_2 { get; set; }
        public string DIRECCION_LEGAL_DNI { get; set; }
        public Nullable<int> REPRESENTANTE_LEGAL_DNI { get; set; }
        public Nullable<int> ID_TIPO_FURGON { get; set; }
        public Nullable<int> ID_TIPO_CARROCERIA_TARPRO { get; set; }
        public Nullable<int> ID_TIPO_ATENCION { get; set; }
        public string INFORME_SDHPA { get; set; }
    
        public virtual MAE_PROTOCOLO MAE_PROTOCOLO { get; set; }
    }
}
