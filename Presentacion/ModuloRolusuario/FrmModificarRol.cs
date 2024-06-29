using System;

namespace Presentacion.ModuloRolusuario
{
    public partial class FrmModificarRol : MaterialSkin.Controls.MaterialForm
    {
        public FrmModificarRol()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
