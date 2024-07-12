using System;

namespace Datos.Models
{
    /// <summary>
    /// Representa un usuario en el sistema.
    /// </summary>
    public partial class Usuario : BaseEntity<int>
    {
        public int IdPersona { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] ContrasenaHash { get; set; }
        public byte[] ContrasenaSalt { get; set; }
        public int IdRol { get; set; }

        public virtual Persona PersonaNavegation { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
