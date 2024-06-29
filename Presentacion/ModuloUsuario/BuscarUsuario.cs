using MaterialSkin;
using System;

namespace Presentacion.ModuloUsuario
{
    public partial class BuscarUsuario : MaterialSkin.Controls.MaterialForm
    {

        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
        }


    }
}
