using System.Collections.Generic;

namespace Datos.Models
{
    public partial class TipoCuenta : BaseEntity<int>
    {
        public TipoCuenta()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        // Relación con Cuentas (uno a muchos)
        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
