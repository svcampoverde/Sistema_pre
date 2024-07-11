using System;

namespace Datos.Models
{
    public partial class Cliente : BaseEntity<int>
    {
        public int IdPersona { get; set; }
        public int IdCiudad { get; set; }
        public int CuentaId { get; set; }
        public int EmpresaId { get; set; }
        public int FormaPagoId { get; set; }
        public decimal LimiteCredito { get; set; }
        public string ContactoCorreo { get; set; }
        public string ContactoTelefono { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual Cuenta Cuenta { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual FormaPago FormaPago { get; set; }
    }
}
