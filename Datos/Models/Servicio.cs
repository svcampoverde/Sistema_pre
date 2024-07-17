using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Servicio : BaseEntity<int>
    {
        public Servicio()
        {
            PresupuestoDetalles = new HashSet<PresupuestoDetalle>();
            Proveedores = new HashSet<Proveedor>();
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoServicio { get; set; }

        public virtual TipoServicio TipoServicio { get; set; }
        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
