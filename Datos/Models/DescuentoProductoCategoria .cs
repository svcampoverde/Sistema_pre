using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Datos.Models
{
    public partial class DescuentoProductoCategoria : BaseEntity<int>
    {
        public int? IdProducto { get; set; }
        public int? IdCategoriaProducto { get; set; }
        public int IdDescuento { get; set; }
        public decimal? TasaEspecifica { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual Descuento Descuento { get; set; }
    }
}

