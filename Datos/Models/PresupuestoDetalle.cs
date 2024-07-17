using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class PresupuestoDetalle : BaseEntity<int>
    {
        public int IdServicio { get; set; }
        public int IdProducto { get; set; }
        public int IdPresupuesto { get; set; }
        public decimal ValorBase { get; set; } // Valor base del detalle
        public decimal TotalDescuentos { get; set; } // Total de descuentos aplicados al detalle
        public decimal TotalImpuestos { get; set; } // Total de impuestos aplicados al detalle
        public int Cantidad { get; set; } // Cantidad del producto o servicio en el detalle

        public virtual Presupuesto IdPresupuestoNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
        public virtual Servicio ServicionNavegation { get; set; }
        public virtual ICollection<DescuentoPresupuestoDetalle> DescuentoPresupuestoDetalle { get; set; }
    }
}
