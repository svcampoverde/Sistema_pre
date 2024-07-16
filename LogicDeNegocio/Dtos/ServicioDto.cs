using System;
using System.Collections.Generic;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Dtos
{
    public class ServicioDto 
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string TipoServicio { get; set; }

    }
}
