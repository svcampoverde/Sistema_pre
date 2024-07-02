using System;

namespace Datos.Models
{
    public partial class Empleado : BaseEntity<int>
    {
        public int IdPersona { get; set; }
        public string Empresa { get; set; }
        public float Sueldo { get; set; }
        public DateTime? FechaContrato { get; set; }
        public int IdCiudad { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
