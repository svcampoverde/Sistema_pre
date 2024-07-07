using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Persona : BaseEntity<int>
    {
        public Persona()
        {
            Clientes = new HashSet<Cliente>();
            Empleados = new HashSet<Empleado>();
            Proveedores = new HashSet<Proveedor>();
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }

        public virtual Ciudad CiudadNavegation { get; set; }
        public virtual Usuario UsuarioNavegation { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
