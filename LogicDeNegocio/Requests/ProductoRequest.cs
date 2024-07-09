using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class ProductoRequest
    {
        // Propiedades generadas automáticamente
        public string Descripcion { get; set; }
         public float Precio { get; set; }
         public int IdCategoriaProducto { get; set; }
         public int? IdTipoProducto { get; set; }
}
}
