using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Requests
{
    public class EmpresaRequest
    {
        // Propiedades generadas automáticamente
        public int Id {  get; set; }
        public string Descripcion { get; set; }
         public string Telefono { get; set; }
         public string Correo { get; set; }
         public string Direccion { get; set; }
         public int IdTipoEmpresa { get; set; }
        public string TipoEmpresaDescripcion { get; set; }
    }
}
