using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Producto : BaseEntity<int>
    {
        public Producto()
        {
            PresupuestoDetalles = new HashSet<PresupuestoDetalle>();
        }

        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Inventario Inventario { get; set; }

        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }
    }
}
