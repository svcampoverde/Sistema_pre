using System.Collections.Generic;

namespace Datos.Models
{
    public class CategoriaProducto : BaseEntity<int>
    {
        public CategoriaProducto()
        {
            Productos = new HashSet<Producto>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<ImpuestoProductoCategoria> ImpuestoProductoCategorias { get; set; }

    }
}
