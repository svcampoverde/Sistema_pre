using System.Collections.Generic;

namespace Datos.Models
{
    public partial class TipoEmpresa : BaseEntity<int>
    {
        public TipoEmpresa()
        {
            Empresas = new HashSet<Empresa>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
