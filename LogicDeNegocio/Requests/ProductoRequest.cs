using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class ProductoRequest
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int? IdTipoProducto { get; set; }
    }
}
