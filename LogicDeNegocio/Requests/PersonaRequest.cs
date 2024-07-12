using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LogicDeNegocio.Requests
{
    public class PersonaRequest
    {
        // Propiedades generadas automáticamente
        public string Cedula { get; set; }
         public string Nombre { get; set; }
        [Description("Nombre Usuario")]
         public string NombreUsuario { get; set; }
         public string Apellido { get; set; }
         public string Genero { get; set; }
         public string Telefono { get; set; }
         public string Celular { get; set; }
         public string Correo { get; set; }
         public string Direccion { get; set; }
         public int IdCiudad { get; set; }
}
}
