using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Dtos
{
    public class ServicioRequest
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int idTipoServicio { get; set; }
    }
}
