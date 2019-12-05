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
    
    public partial class DocumentoDetalleRequest
    {
        public int id_det_documento { get; set; }
        public int id_documento { get; set; }
        public Nullable<int> id_cab_det_documento { get; set; }
        public int oficina_destino { get; set; }
        public string observacion { get; set; }
        public byte id_est_tramite { get; set; }
        public string persona_num_documento { get; set; }
        public Nullable<bool> ind_01 { get; set; }
        public Nullable<bool> ind_02 { get; set; }
        public Nullable<bool> ind_03 { get; set; }
        public Nullable<bool> ind_04 { get; set; }
        public Nullable<bool> ind_05 { get; set; }
        public Nullable<bool> ind_06 { get; set; }
        public Nullable<bool> ind_07 { get; set; }
        public Nullable<bool> ind_08 { get; set; }
        public Nullable<bool> ind_09 { get; set; }
        public Nullable<bool> ind_10 { get; set; }
        public Nullable<bool> ind_11 { get; set; }
        public string indicadores { get; set; }
        public Nullable<System.DateTime> fecha_recepcion { get; set; }
        public string usuario_recepcion { get; set; }
        public Nullable<System.DateTime> fecha_atendido { get; set; }
        public string usuario_atendido { get; set; }
        public Nullable<System.DateTime> fecha_archivo { get; set; }
        public string usuario_archivo { get; set; }
        public Nullable<System.DateTime> fecha_derivado { get; set; }
        public string usuario_derivado { get; set; }
        public string usuario_crea { get; set; }
        public System.DateTime fecha_crea { get; set; }
        public int oficina_crea { get; set; }
        public string usuario_cancelar { get; set; }
        public Nullable<System.DateTime> fecha_cancelar { get; set; }
        public string observacion_archivo { get; set; }
        public string observacion_atendido { get; set; }
        public string nom_oficina_crea { get; set; }
        public string nom_oficina_destino { get; set; }
    
        public virtual EstadoTramiteRequest estado_tramite { get; set; }
        public virtual List<LogDesarchivoDesatendidoRequest> log_desarchivo_desatendido { get; set; }
        public virtual List<DocDetObservacionesRequest> doc_det_observaciones { get; set; }
        public virtual DocumentoRequest documento { get; set; }
    }
}
