using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Models
{
    public partial class ImpuestoProductoCategoria : BaseEntity<int>
    {
        public int? IdProducto { get; set; }
        public int? IdCategoriaProducto { get; set; }
        public int IdImpuesto { get; set; }
        public decimal? TasaEspecifica { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual Impuesto Impuesto { get; set; }
    }
}

