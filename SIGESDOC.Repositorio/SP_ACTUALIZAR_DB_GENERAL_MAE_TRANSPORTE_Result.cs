//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGESDOC.Repositorio
{
    using System;
    
    public partial class SP_ACTUALIZAR_DB_GENERAL_MAE_TRANSPORTE_Result
    {
        public int id_transporte { get; set; }
        public string placa { get; set; }
        public string cod_habilitacion { get; set; }
        public Nullable<int> id_tipo_carroceria { get; set; }
        public string nombre_carroceria { get; set; }
        public Nullable<int> id_tipo_furgon { get; set; }
        public string nombre_furgon { get; set; }
        public Nullable<int> id_um { get; set; }
        public string nombre_um { get; set; }
        public string siglas_um { get; set; }
        public Nullable<decimal> carga_util { get; set; }
        public string estado { get; set; }
        public string nombre_estado { get; set; }
    }
}
