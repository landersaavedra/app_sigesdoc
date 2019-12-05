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
    
    public partial class SeguimientoDhcpaRequest
    {
        public int id_seguimiento { get; set; }
        public Nullable<int> id_expediente { get; set; }
        public Nullable<int> tupa { get; set; }
        public Nullable<int> id_tipo_procedimiento { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<int> id_ofi_dir { get; set; }
        public string persona_num_documento { get; set; }
        public string evaluador { get; set; }
        public Nullable<int> id_embarcacion { get; set; }
        public Nullable<int> id_planta { get; set; }
        public Nullable<int> oficina_crea { get; set; }
        public string persona_crea { get; set; }
        public string estado { get; set; }
        public Nullable<int> duracion_tramite { get; set; }
        public Nullable<int> duracion_sdhpa { get; set; }
        public string observaciones { get; set; }
        public string inspecto_designado { get; set; }
        public Nullable<System.DateTime> fecha_auditoria { get; set; }
        public Nullable<System.DateTime> fecha_envio_acta { get; set; }
        public Nullable<System.DateTime> fecha_envio_oficio_sdhpa { get; set; }
        public string con_proceso { get; set; }
        public Nullable<int> id_tipo_seguimiento { get; set; }
        public Nullable<int> id_habilitante { get; set; }
        public string cod_habilitante { get; set; }
        public string nom_oficina_crea { get; set; }
        public string nombre_externo { get; set; }
    
        public virtual List<DetSegDocRequest> det_seg_doc { get; set; }
        public virtual List<DetSegDocDhcpaRequest> det_seg_doc_dhcpa { get; set; }
        public virtual List<DetSegEvaluadorRequest> det_seg_evaluador { get; set; }
        public virtual List<ConstanciaHaccpRequest> constancia_haccp { get; set; }
        public virtual List<InformeTecnicoEvalRequest> informe_tecnico_eval { get; set; }
        public virtual List<ProtocoloRequest> protocolo { get; set; }
        public virtual List<SeguimientoDhcpaObservacionesRequest> seguimiento_dhcpa_observaciones { get; set; }
        public virtual List<SolicitudInspeccionRequest> solicitud_inspeccion { get; set; }
    }
}
