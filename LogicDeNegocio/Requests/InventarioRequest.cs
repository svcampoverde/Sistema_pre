using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class InventarioRequest
    {
        // Propiedades generadas automáticamente
        public int ProductoId { get; set; }
         public int Cantidad { get; set; }
         public string Ubicacion { get; set; }
         public string EstadoProducto {  get; set; }
         public decimal PrecioCompra { get; set; }
         public decimal PrecioVenta { get; set; }
        public string Digitador {  get; set; }
        public string TipoMaterial {  get; set; }
}
}
