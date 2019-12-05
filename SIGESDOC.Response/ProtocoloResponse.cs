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
    
    public partial class ProtocoloResponse
    {
        public int id_protocolo { get; set; }
        public Nullable<int> id_seguimiento { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string evaluador { get; set; }
        public string ind_concha_abanico { get; set; }
        public string ind_otros { get; set; }
        public string ind_peces { get; set; }
        public string ind_crustaceos { get; set; }
        public Nullable<int> id_tipo_ch { get; set; }
        public string activo { get; set; }
        public Nullable<int> id_ind_pro_esp { get; set; }
        public Nullable<int> id_est_pro { get; set; }
        public Nullable<int> id_protocolo_reemplaza { get; set; }
    
        public virtual List<ProtocoloAlmacenResponse> protocolo_almacen { get; set; }
        public virtual List<ProtocoloAutorizacionInstalacionResponse> protocolo_autorizacion_instalacion { get; set; }
        public virtual List<ProtocoloConcesionResponse> protocolo_concesion { get; set; }
        public virtual List<ProtocoloDesembarcaderoResponse> protocolo_desembarcadero { get; set; }
        public virtual List<ProtocoloEmbarcacionResponse> protocolo_embarcacion { get; set; }
        public virtual List<ProtocoloEspecieResponse> protocolo_especie { get; set; }
        public virtual List<ProtocoloLicenciaOperacionResponse> protocolo_licencia_operacion { get; set; }
        public virtual List<ProtocoloPlantaResponse> protocolo_planta { get; set; }
        public virtual TipoConsumoHumanoResponse tipo_consumo_humano { get; set; }
        public virtual List<ProtocoloTransporteResponse> protocolo_transporte { get; set; }
        public virtual List<ActividadProtocoloResponse> actividad_protocolo { get; set; }
        public virtual SeguimientoDhcpaResponse seguimiento_dhcpa { get; set; }
    }
}
