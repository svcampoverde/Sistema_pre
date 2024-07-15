using System.Collections.Generic;

namespace Datos.Models
{
    public partial class TipoProducto : BaseEntity<int>
    {
        public TipoProducto()
        {
            Productos = new HashSet<Producto>();
        }

       // public int Id{ get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
