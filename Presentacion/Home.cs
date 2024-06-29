using MaterialSkin;
using System;

namespace Presentacion
{
    public partial class Home : MaterialSkin.Controls.MaterialForm
    {


        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            //Home.Hide();
        }

        private void ContenPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
