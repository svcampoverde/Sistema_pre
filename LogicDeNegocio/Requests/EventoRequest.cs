using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class EventoRequest
    {
        // Propiedades generadas automáticamente
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Promotor { get; set; }
        public string Artista { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
    }
}
