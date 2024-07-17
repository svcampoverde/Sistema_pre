using System.Collections.Generic;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Producto : BaseEntity<int>
    {
        public Producto()
        {
            PresupuestoDetalles = new HashSet<PresupuestoDetalle>();
            AtributosProductos = new HashSet<AtributoProducto>();
            DescuentosProductoCategoria = new HashSet<DescuentoProductoCategoria>();
            ImpuestosProductoCategoria = new HashSet<ImpuestoProductoCategoria>();
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int? IdTipoProducto { get; set; }

        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual TipoProducto TipoProducto { get; set; }
        public virtual Inventario Inventario { get; set; }
        public virtual ICollection<DescuentoProductoCategoria> DescuentosProductoCategoria { get; set; }
        public virtual ICollection<ImpuestoProductoCategoria> ImpuestosProductoCategoria { get; set; }
        public virtual ICollection<AtributoProducto> AtributosProductos { get; set; }
        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }
    }
}
