using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.ModuloCiudad
{
    public partial class FrmCiudad : MaterialSkin.Controls.MaterialForm
    {
        private readonly SistemapContext _sistemapContext;

        public FrmCiudad(SistemapContext sistemapContext)
        {
            InitializeComponent();
            llenarCombobox();
            _sistemapContext = sistemapContext;
        }
        private void llenarCombobox()
        {
            try
            {
                List<Provincia> list = _sistemapContext.Provincias.ToList();
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

                    Ciudad ciu = new Ciudad();
                    ciu.Nombre = ciudad;
                    ciu.IdProvincia = idp;
                    _sistemapContext.Add(ciu);
                    _sistemapContext.SaveChanges();
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
            if (txtCiudad.Text == "")
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
