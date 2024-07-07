using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    public class BaseEntity<T> : BaseEntity where T : struct
    {
        [Column( Order = 1)]
        public T Id { get; set; }
    }
    public class BaseEntity
    {
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacionUTC { get; set; } = DateTime.UtcNow;
        public DateTime FechaModificacionUTC { get; set; }
    }

}
