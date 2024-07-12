using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogicDeNegocio.Requests
{
    public class UsuarioRequest
    {
  

        [Required]
        public int IdCiudad { get; set; }

        [Required]
        public int IdRol { get; set; }

        [Required]
        [StringLength(10)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(10)]
        public string Genero { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(15)]
        public string Celular { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Clave { get; set; }
    }

}
