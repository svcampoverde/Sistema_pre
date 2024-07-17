using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class Descuento : BaseEntity<int>
    {
        public Descuento()
        {
            DescuentoPresupuestoDetalle = new HashSet<DescuentoPresupuestoDetalle>();
        }
        public string Nombre { get; set; }
        public decimal Tasa { get; set; }
        public bool EsPorcentaje { get; set; }
        public ICollection<DescuentoPresupuestoDetalle> DescuentoPresupuestoDetalle { get; internal set; }
    }

}
