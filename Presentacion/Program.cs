using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.ModuloCiudad;
using Presentacion.ModuloLogin;
using Presentacion.ModuloUsuario;

namespace Presentacion
{
     static class Program
    {
        public static FRMPrincipal iniciar = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(iniciar = new FRMPrincipal());
           // Application.Run(new FRMPrincipal());
        }
    }
}
