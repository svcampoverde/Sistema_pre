using System.Collections.Generic;

namespace Datos.Models
{
    public class CategoriaProducto : BaseEntity<int>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }

    }
}
