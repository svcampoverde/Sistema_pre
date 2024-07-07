using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Producto : BaseEntity<int>
    {
        public Producto()
        {
            PresupuestoDetalles = new HashSet<PresupuestoDetalle>();
            AtributosProductos = new HashSet<AtributoProducto>();
        }

        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int? IdTipoProducto { get; set; } // Nullable para permitir que un producto no tenga tipo

        // Propiedades de navegación
        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual TipoProducto TipoProducto { get; set; } // Nueva propiedad de navegación para TipoProducto
        public virtual Inventario Inventario { get; set; }
        public virtual ICollection<AtributoProducto> AtributosProductos { get; set; }
        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }
    }
}
