using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Datos.Models
{
    public partial class Banco : BaseEntity<int>
    {
        public Banco()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(200, ErrorMessage = "La longitud máxima de la descripción es 200 caracteres.")]
        public string Descripcion { get; set; }

        [StringLength(500, ErrorMessage = "La longitud máxima de la dirección es 500 caracteres.")]
        public string Direccion { get; set; }

        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
