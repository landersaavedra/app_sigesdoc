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
    
    public partial class ProtocoloAlmacenResponse
    {
        public int id_dat_pro_almacen { get; set; }
        public Nullable<int> id_protocolo { get; set; }
        public Nullable<int> direccion_legal { get; set; }
        public Nullable<int> representante_legal { get; set; }
        public string licencia { get; set; }
        public Nullable<int> id_tipo_ch { get; set; }
    
        public virtual ProtocoloResponse protocolo { get; set; }
        public virtual TipoConsumoHumanoResponse tipo_consumo_humano { get; set; }
    }
}
