using LogicDeNegocio.provincia;
using LogicDeNegocio;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicDeNegocio.personas;

namespace Presentacion.ModuloRolusuario
{
    public partial class FRMRol : MaterialSkin.Controls.MaterialForm
    {
        AdmRol admr = new AdmRol();
        public FRMRol()
        {
            InitializeComponent();
        }

        private void FRMRol_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
        }

        private void btnRegistrarol_Click(object sender, EventArgs e)
        {
            string rol = txtRol.Text;
            try
            {
                if (Validar())
                {

                    Rol r = new Rol(rol);
                    admr.insertRol(r);
                    MessageBox.Show("Registro de provincia realizado con éxito");
                    Limpiar();
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validar()
        {
            bool campo = true;
            if (txtRol.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtRol, "Ingrese nombre de provincia");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtRol.Clear();
        }

    }
}
