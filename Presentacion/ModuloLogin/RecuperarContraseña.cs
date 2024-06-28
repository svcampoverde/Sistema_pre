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

namespace Presentacion.ModuloLogin
{
    public partial class RecuperarContraseña : MaterialSkin.Controls.MaterialForm
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
        }

        private void chnpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chnpass.Checked)
            {
                txtnpass.PasswordChar = '\0';
            }else
            {
                txtnpass.PasswordChar = '*';
            }
            
        }

        private void chcpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chcpass.Checked)
            {
                txtcpass.PasswordChar = '\0';
            }
            else
            {
                txtcpass.PasswordChar = '*';


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtnpass.Text == txtcpass.Text)
            {
                MessageBox.Show("son igules");
            }else
            {
                MessageBox.Show("Verificar las claves no coinciden");
            }
        }
    }
}
