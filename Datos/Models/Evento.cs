using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Evento : BaseEntity<int>
    {
        public Evento()
        {
            PresupuestoNavegation = new HashSet<Presupuesto>();
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Promotor { get; set; }
        public string Artista { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
        public Ciudad CiudadNavegation { get; set; }
        public virtual ICollection<Presupuesto> PresupuestoNavegation { get; set; }
    }
}
