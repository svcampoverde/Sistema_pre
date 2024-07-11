using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    public partial class Banco : BaseEntity<int>
    {
        public Banco()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        [Column(Order = 2)]
        public string Nombre { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(200, ErrorMessage = "La longitud máxima de la descripción es 200 caracteres.")]
        public string Descripcion { get; set; }

        [Column(Order = 4)]
        [StringLength(500, ErrorMessage = "La longitud máxima de la dirección es 500 caracteres.")]
        public string Direccion { get; set; }

        [Column(Order = 5)]
        public int IdCategoriaBanco { get; set; }

        public virtual CategoriaBanco CategoriaBanco { get; set; }
        public virtual ICollection<Cuenta> Cuenta { get; set; }

        [Column(Order = 6)]
        [StringLength(20, ErrorMessage = "La longitud máxima del teléfono es 20 caracteres.")]
        public string Telefono { get; set; }
    }
}
