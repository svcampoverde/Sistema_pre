using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Rol : BaseEntity<int>
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
