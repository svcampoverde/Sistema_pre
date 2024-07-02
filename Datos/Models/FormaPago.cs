using System.Collections.Generic;

namespace Datos.Models
{
    /// <summary>
    /// Representa una forma de pago en el sistema.
    /// </summary>
    public partial class FormaPago : BaseEntity<int>
    {
        public FormaPago()
        {
            Clientes = new HashSet<Cliente>();
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public virtual ICollection<Proveedor> Proveedores{ get; set; } = new List<Proveedor>();
    }
}
