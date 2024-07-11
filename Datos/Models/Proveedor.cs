namespace Datos.Models
{
    public partial class Proveedor : BaseEntity<int>
    {
        public int IdPersona { get; set; }
        public string Empresa { get; set; }
        public string TipoServicio { get; set; }
        public int IdCiudad { get; set; }
        public int ServicioId { get; set; }
        public int IdCuenta { get; set; }
        public int IdFormaPago { get; set; }
        public int IdEmpresa { get; set; }
        public FormaPago FormaPago { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
        public virtual Cuenta IdCuentaNavigation { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual Servicio ServicionNavegation { get; set; }
    }
}
