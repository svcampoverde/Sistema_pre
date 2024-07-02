using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Cuenta : BaseEntity<int>
    {
        public Cuenta()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedor>();
        }

        public string NumCuenta { get; set; }
        public int IdBanco { get; set; }
        public int IdTipoCuenta { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual TipoCuenta IdTipoCuentaNavigation { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
