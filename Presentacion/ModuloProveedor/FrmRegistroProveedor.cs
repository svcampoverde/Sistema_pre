using Datos.Models;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Personas;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Services;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloProveedor
{
    public partial class FrmRegistroProveedor : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly ICiudadService _ciudadService;
        private readonly ITipoServicioService _ipoServicioService;

        public FrmRegistroProveedor(IProveedorService proveedorService, ICiudadService ciudadService, ITipoServicioService ipoServicioService)
        {
            InitializeComponent();
            _proveedorService = proveedorService ?? throw new ArgumentNullException(nameof(proveedorService)); 
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            _ipoServicioService = ipoServicioService ?? throw new ArgumentNullException(nameof(ipoServicioService));
        }

        private void FrmRegistroProveedor_Load(object sender, EventArgs e)
        {

        }
        private async Task LlenarComboBoxRoles()
        {
            try
            {
                var tipoServicios = await _ipoServicioService.ObtenerTodasTipoServicios();//_rolService.ObtenerTodosLosRoles();
                if (tipoServicios.Any())
                {
                    cmbServicio.DataSource = tipoServicios;
                    cmbServicio.DisplayMember = "Descripcion";
                    cmbServicio.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LlenarComboBoxCiudades()
        {
            try
            {
                var ciudades = await _ciudadService.obtenerCiudades();
                if (ciudades.Any())
                {
                    cmbCiudad.DataSource = ciudades;
                    cmbCiudad.DisplayMember = "Nombre";
                    cmbCiudad.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarprove_Click(object sender, EventArgs e)
        {
            int idservicio = Convert.ToInt32(cmbServicio.Texts);
            int idprovincia = Convert.ToInt32(cmbCiudad.Texts);
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string genero = cmbGenero.Texts;
            string telefono = txtTelefono.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string empresa = txtEmpresa.Text.Trim();
            string cuenta = txtCuenta.Text.Trim();
            var request = new ProveedorRequest
            {

            };
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
