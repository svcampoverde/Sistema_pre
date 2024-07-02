using System;

namespace Datos.Models
{
    public class BaseEntity<T> : BaseEntity where T : struct
    {
        public T Id { get; set; }
    }

    public class BaseEntity
    {
        public DateTime FechaCreacionUTC { get; set; } = DateTime.UtcNow;
        public DateTime FechaModificacionUTC { get; set; }
        public bool Activo { get; set; } = true;
    }



}
