using Datos.AplicationDB;
using LogicDeNegocio;
using System;
using System.Windows.Forms;

namespace Presentacion.ModuloProvincia

{
    public partial class FrmProvincia : MaterialSkin.Controls.MaterialForm
    {
        private readonly SistemapContext _sistemapContext;
        public FrmProvincia(SistemapContext sistemapContext)
        {
            _sistemapContext = sistemapContext;

            InitializeComponent();
        }

        private void btnRegistrarp_Click(object sender, EventArgs e)
        {
            //int id =0;
            string prov = txtProvincia.Text;
            try
            {
                if (Validar())
                {

                    //Provincia provincia = new Provincia(prov);
                    //admp.insertarProvincia(provincia);
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
            if (txtProvincia.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtProvincia, "Ingrese nombre de provincia");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtProvincia.Clear();
        }
    }
}
