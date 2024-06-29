using System;

namespace LogicDeNegocio
{
    public class ExceptionSistema : Exception
    {
        String mensaje = null;

        public ExceptionSistema(String mensaje) : base(mensaje)
        {
            Console.WriteLine(this.mensaje);
        }
    }
}
