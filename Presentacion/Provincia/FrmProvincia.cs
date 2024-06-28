using LogicDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Provincia
{
    public partial class FrmProvincia : MaterialSkin.Controls.MaterialForm
    {
        public FrmProvincia()
        {
            InitializeComponent();
        }

        private void btnRegistrarp_Click(object sender, EventArgs e)
        {
            string provincia = txtProvincia.Text;
            try
            {

            }catch(ExceptionSistema ex) 
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validar()
        {
           bool campo = true;
            if(txtProvincia.Text == "") 
            { 
                campo = false;
                errorProvider1.SetError(txtProvincia, "Ingrese nombre de provincia");
            }
           return campo;
        }
    }
}
