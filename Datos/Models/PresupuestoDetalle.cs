using System;

namespace Datos.Models
{
    public partial class PresupuestoDetalle : BaseEntity<int>
    {
        public string Servicio { get; set; }
        public int IdServicio { get; set; }
        public int IdProducto { get; set; }
        public int IdPresupuesto { get; set; }

        public virtual Presupuesto IdPresupuestoNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
        public virtual Servicio ServicionNavegation { get; set; }
    }
}
