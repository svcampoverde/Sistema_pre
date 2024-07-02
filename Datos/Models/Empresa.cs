using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Empresa : BaseEntity<int>
    {
        public Empresa()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedor>();
        }

        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int IdTipoEmpresa { get; set; }

        public virtual TipoEmpresa IdTipoEmpresaNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
