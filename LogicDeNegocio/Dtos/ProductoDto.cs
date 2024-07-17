using System;
using System.Collections.Generic;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Dtos
{
    public class ProductoDto 
    {
        public string Nombre { get; set; }
        public string NombreCategoria { get; set; }
        public string TipoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Id { get; set; }

    }
}
