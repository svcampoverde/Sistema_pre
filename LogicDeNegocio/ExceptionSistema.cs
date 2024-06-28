using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio
{
    public class ExceptionSistema: Exception
    {
        String mensaje = null;

        public ExceptionSistema(String mensaje):base(mensaje)
        {
            Console.WriteLine(this.mensaje);
        }
    }
}
