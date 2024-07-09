using System.Collections.Generic;

namespace Datos.Models
{
    public class Provincia 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }

    }
}
