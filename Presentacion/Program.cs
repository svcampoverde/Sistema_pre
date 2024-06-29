using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.ModuloCiudad;
using Presentacion.ModuloLogin;
using Presentacion.ModuloUsuario;
using Unity;

namespace Presentacion
{
     static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Resolver el formulario principal con Unity
            var form = UnityConfig.Container.Resolve<FRMPrincipal>();
            Application.Run(form);
            // Application.Run(new FRMPrincipal());
        }
    }
}
