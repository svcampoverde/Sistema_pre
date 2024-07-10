﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmRegistrarUsuario : Form, IForm
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IRolService _rolService;
        private readonly ICiudadService _ciudadService;

        public FrmRegistrarUsuario(IUsuarioService usuarioService, IRolService rolService, ICiudadService ciudadService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
            _rolService = rolService ?? throw new ArgumentNullException(nameof(rolService));
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private async void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            await LlenarComboBoxRoles();
            await LlenarComboBoxCiudades();
        }
        private async Task LlenarComboBoxRoles()
        {
            try
            {
                var roles = await _rolService.ObtenerTodosLosRoles();
                if (roles.Any())
                {
                    cbRol.DataSource = roles;
                    cbRol.DisplayMember = "Descripcion";
                    cbRol.ValueMember = "Id";
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                int idRol = Convert.ToInt32(cbRol.SelectedValue);
                string cedula = txtCedula.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string genero = cmbGenero.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text.Trim();

                var request = new UsuarioRequest
                {
                    IdCiudad = idCiudad,
                    IdRol = idRol,
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Genero = genero,
                    Telefono = telefono,
                    Celular = celular,
                    Correo = correo,
                    Direccion = direccion,
                    Usuario = usuario,
                    Clave = clave,
                };

                await _usuarioService.RegistrarUsuarioAsync(request);
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbGenero.SelectedIndex = -1;
            txtTelefono.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        public void ShowForm()
        {
            this.Show();
        }
     
        private void txtCedula_Click(object sender, EventArgs e)
        {
            BorrarAlertas();
        }

        private void BorrarAlertas()
        {
            errorProvider1.Clear();
        }

        private async void cbRol_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRol.SelectedIndex != -1)
            {
                 LlenarComboBoxRoles();
            }
        }

        private async void cmbCiudad_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedIndex != -1)
            {
                 LlenarComboBoxCiudades();
            }
        }
    }
}
