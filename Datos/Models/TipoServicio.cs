using System.Collections.Generic;

namespace Datos.Models
{
    public class TipoServicio : BaseEntity<int>
    {
        public TipoServicio()
        {
            Servicios = new HashSet<Servicio>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        // Relación con Servicio (uno a muchos)
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
