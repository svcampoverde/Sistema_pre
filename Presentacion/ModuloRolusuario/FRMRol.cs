using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace Presentacion.ModuloRolusuario
{
    public partial class FRMRol : MaterialSkin.Controls.MaterialForm
    {
        private readonly SistemapContext _sistemapContext;
        public FRMRol(SistemapContext sistemapContext)
        {
            _sistemapContext = sistemapContext;

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
                    Rol rol1 = new Rol() {
                        Descripcion = rol
                    }; 
                    _sistemapContext.Roles.Add(rol1);
                    _sistemapContext.SaveChanges();
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
