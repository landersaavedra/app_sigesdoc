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
    
    public partial class DAT_PROTOCOLO_PLANTA
    {
        public int ID_DAT_PRO_PLA { get; set; }
        public Nullable<int> ID_PROTOCOLO { get; set; }
        public Nullable<int> DIRECCION_LEGAL { get; set; }
        public Nullable<int> REPRESENTANTE_LEGAL { get; set; }
        public string LICENCIA_OPERACION { get; set; }
        public string IND_CONCHA_ABANICO { get; set; }
        public string IND_OTROS { get; set; }
        public string IND_PECES { get; set; }
        public string IND_CRUSTACEOS { get; set; }
        public Nullable<int> ID_TIPO_CH { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual MAE_PROTOCOLO MAE_PROTOCOLO { get; set; }
        public virtual MAE_TIPO_CONSUMO_HUMANO MAE_TIPO_CONSUMO_HUMANO { get; set; }
    }
}
