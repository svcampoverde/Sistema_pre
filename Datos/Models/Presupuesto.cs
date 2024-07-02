using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Presupuesto : BaseEntity<int>
    {
        public Presupuesto()
        {
            PresupuestoDetalles = new HashSet<PresupuestoDetalle>();
        }

        public int Codigo { get; set; }
        public float Version { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public float Descuento { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
        public int IdEvento { get; set; }

        public virtual Evento IdeventoNavigation { get; set; }
        public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; set; }
    }
}
