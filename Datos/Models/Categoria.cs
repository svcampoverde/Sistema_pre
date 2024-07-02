using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Categoria : BaseEntity<int>
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
