using System.Collections;
using System.Collections.Generic;

namespace Datos.Models
{
    public class Atributo : BaseEntity<int>
    {
        public string Nombre { get; set; }
        public string Unidades { get; set; }
        public int IdCategoriaAtributo { get; set; }
        public virtual CategoriaAtributo CategoriaAtributo { get; set; }
        public virtual ICollection<AtributoProducto> AtributosProductos { get;  set; }
    }
}
