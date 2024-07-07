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

        public string Descripcion { get; set; }
        public int IdTipoServicio { get; set; }
        public TipoServicio TipoServicio { get; set; }
        // Relación con PresupuestoDetalle
        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }

        // Relación con Proveedor
        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
