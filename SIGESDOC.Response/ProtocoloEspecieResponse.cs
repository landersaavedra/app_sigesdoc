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
    
    public partial class ProtocoloEspecieResponse
    {
        public int id_pro_espe { get; set; }
        public Nullable<int> id_protocolo { get; set; }
        public Nullable<int> id_det_espec_hab { get; set; }
        public string activo { get; set; }
    
        public virtual EspeciesHabilitacionesResponse especies_habilitaciones { get; set; }
        public virtual ProtocoloResponse protocolo { get; set; }
    }
}