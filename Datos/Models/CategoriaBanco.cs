using System.Collections.Generic;

namespace Datos.Models
{
    public class CategoriaBanco : BaseEntity<int>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Banco> Bancos { get; set; } = new HashSet<Banco>();
    }
}
