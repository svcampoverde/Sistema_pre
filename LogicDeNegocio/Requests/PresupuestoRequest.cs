using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class PresupuestoRequest
    {
        // Propiedades generadas automáticamente
        public int Codigo { get; set; }
         public float Version { get; set; }
         public string Descripcion { get; set; }
         public DateTime FechaEvento { get; set; }
         public DateTime FechaCotizacion { get; set; }
         public float Descuento { get; set; }
         public float Iva { get; set; }
         public float Total { get; set; }
         public int IdEvento { get; set; }
}
}
