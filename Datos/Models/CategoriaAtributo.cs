
using System.Collections.Generic;

namespace Datos.Models
{
    public class CategoriaAtributo : BaseEntity<int>
    {
        public CategoriaAtributo()
        {
            Atributos = new HashSet<Atributo>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Atributo> Atributos { get; set; }
    }
}
