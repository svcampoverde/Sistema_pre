using Datos.AplicationDB;
using FluentValidation;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmRegistrarUsuario : MaterialSkin.Controls.MaterialForm
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IUserService userService;

        public FrmRegistrarUsuario(SistemapContext sistemapContext, IUserService userService)
        {
            this.userService = userService;
            _sistemapContext = sistemapContext;
            InitializeComponent();
            llenarCombobox();

        }
        private void llenarCombobox()
        {
            try
            {
                var list = _sistemapContext.Rols.ToList();

                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No se encontraron roles para cargar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cbRol.DataSource = null;
                cbRol.DataSource = list;
                cbRol.DisplayMember = "Descripcion";
                cbRol.ValueMember = "Id";
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);

        }



        private void txtCedula_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarAlerta();
            try
            {
                var usuarioDto = new UserDto
                {
                    IdCiudad = Convert.ToInt32(cmbCiudad.SelectedValue),
                    IdRol = Convert.ToInt32(cbRol.SelectedValue),
                    Cedula = txtCedula.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(), 
                    Apellido = txtApellido.Text.Trim(),
                    Genero = cmbGenero.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Celular = txtCelular.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Usuario = txtUsuario.Text.Trim(),
                    Clave = txtClave.Text.Trim()
                };
                 
                var result = await userService.RegistrarUsuarioAsync(usuarioDto);
                // Manejar el resultado
            }
            catch (ValidationException ex)
            {
                // Manejar errores de validación
                var errors = string.Join(Environment.NewLine, ex.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show($"Errores de validación:{Environment.NewLine}{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar otros errores
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
  
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(cmbGenero, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtCelular, "");
            errorProvider1.SetError(cmbCiudad, "");
            errorProvider1.SetError(cbRol, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtClave, "");
        }
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
        }
        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            try
            {
                var list = _sistemapContext.Ciudads.ToList();
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No se encontraron provincias para cargar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmbCiudad.DataSource = null;
                cmbCiudad.DataSource = list;
                cmbCiudad.DisplayMember = "Nombre";
                cmbCiudad.ValueMember = "Id";

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmRegistrarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow email format characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }
    }
}
