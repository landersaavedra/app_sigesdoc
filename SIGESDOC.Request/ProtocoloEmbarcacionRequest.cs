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
    
    public partial class ProtocoloEmbarcacionRequest
    {
        public int id_det_pro_hab { get; set; }
        public Nullable<int> id_protocolo { get; set; }
        public string nom_embarcacion { get; set; }
        public Nullable<int> representante_legal { get; set; }
        public Nullable<int> direccion_legal { get; set; }
        public Nullable<int> id_tip_pro_emb { get; set; }
        public string resolucion { get; set; }
        public string direccion_persona_natural { get; set; }
        public Nullable<int> id_persona_telefono { get; set; }
    
        public virtual ProtocoloRequest protocolo { get; set; }
    }
}