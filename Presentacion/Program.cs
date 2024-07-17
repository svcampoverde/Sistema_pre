using Presentacion.ModuloPresupuesto;
using Presentacion.ModuloProducto;
using Presentacion.ModuloServicio;
using System;
using System.Windows.Forms;
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
            // var form = UnityConfig.Container.Resolve<FormPresupuesto>();
            var form = UnityConfig.Container.Resolve<FrmIPrincipal>();
            Application.Run(form);
            // Application.Run(new FRMPrincipal());
        }
    }
}
