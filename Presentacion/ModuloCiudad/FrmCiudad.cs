using LogicDeNegocio.personas;
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
using LogicDeNegocio.provincia;

namespace Presentacion.ModuloCiudad
{
    public partial class FrmCiudad : MaterialSkin.Controls.MaterialForm
    {
        AdmCiudad admc = new AdmCiudad();
        Provincia adm = new Provincia();
        public FrmCiudad()
        {
            InitializeComponent();
            llenarCombobox();
        }
        private void llenarCombobox()
        {
            try
            {
                List<Provincia> list = adm.llenarCombo();
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No se encontraron provincias para cargar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmbProvincias.Items.Clear();
                cmbProvincias.DataSource = list;
                cmbProvincias.DisplayMember = "Descripcionp";
                cmbProvincias.ValueMember = "Idprovincia";
                
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnGuardarc_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            int idp = Convert.ToInt32(cmbProvincias.SelectedValue);

            try
            {
            
            if (Validar())
            {

                Ciudad ciu = new Ciudad(ciudad, idp);
                admc.insertCiudad(ciu);
                MessageBox.Show("Registro de ciudad realizada con éxito");
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
            if (txtCiudad.Text =="") 
            { 
                campo = false;
                errorProvider1.SetError(txtCiudad, "Ingrese el nombre de la ciudad");
            }

            return campo;
        }

        private void Limpiar()
        {
            txtCiudad.Clear();
        }

        private void FrmCiudad_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
