using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class Impuesto : BaseEntity<int>
    {
        public string Nombre { get; set; }
        public decimal Tasa { get; set; }
        public bool EsPorcentaje { get; set; }
        public virtual ICollection<ImpuestoProductoCategoria> ImpuestoProductoCategoria { get; set; }
    }

}
