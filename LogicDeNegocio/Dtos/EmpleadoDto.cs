using System;
using System.Collections.Generic;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Dtos
{
    public class EmpleadoDto : EmpleadoRequest
    {
        public int Id { get; set; }
        // para consultar
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string CiudadDescripcion { get; set; }

    }
}
