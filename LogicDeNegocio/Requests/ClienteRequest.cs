using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class ClienteRequest
    {
        // Propiedades generadas automáticamente
        public int PersonaId { get; set; }
         public int CiudadId { get; set; }
         public int CuentaId { get; set; }
         public int EmpresaId { get; set; }
         public int FormaPagoId { get; set; }
         public decimal LimiteCredito { get; set; }
         public string ContactoCorreo { get; set; }
         public string ContactoTelefono { get; set; }
         public DateTime FechaRegistro { get; set; }
}
}
