using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Ciudad  
    {
        public Ciudad()
        {
            Clientes = new HashSet<Cliente>();
            Empleados = new HashSet<Empleado>();
            Personas = new HashSet<Persona>();
            Proveedors = new HashSet<Proveedor>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
        public virtual Provincia ProvinciaNavigation { get; set; } // Corregido a ProvinciaNavigation

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
