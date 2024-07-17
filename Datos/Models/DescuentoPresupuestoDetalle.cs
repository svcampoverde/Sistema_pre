using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class DescuentoPresupuestoDetalle : BaseEntity<int>
    {
        public int IdPresupuestoDetalle { get; set; }
        public int IdDescuento { get; set; }
        public virtual PresupuestoDetalle PresupuestoDetalle { get; set; }
        public virtual Descuento Descuento { get; set; }

    }
}
