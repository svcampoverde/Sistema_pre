//using LogicDeNegocio.Empresa;
using LogicDeNegocio;
using Presentacion.btnpersonalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LogicDeNegocio.personas;
//using LogicDeNegocio.provincia;
using DevComponents.DotNetBar.Validator;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Personas;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Dtos;
//using System.Web.Helpers;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmUsuario : Form
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IRolService _rolService;
        private readonly ICiudadService _ciudadService;
        UsuarioDto _usuarioDto;
        int Id;
         string cedul="";
        public FrmUsuario(UsuarioService usuarioService, IRolService rolService, ICiudadService ciudadService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
            _rolService = rolService ?? throw new ArgumentNullException(nameof(rolService));
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            InitializeComponent();

       //     llenarDatagrid(cedul);
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

        public async void llenarDatagrid()
        {
            try
            {
                // var registrousuario = await _usuarioService.ObtenerUsuarioAsync(cedula);
                //  var rowIndex = dtgUsuario.Rows.Add();
                //  var row = dtgUsuario.Rows[rowIndex];

                //  row.Cells["Idusuario"].Value = _usuarioDto.Id;
                //  row.Cells["cedula"].Value = _usuarioDto.Cedula;
                //  row.Cells["name"].Value = _usuarioDto.Nombre;
                //  row.Cells["apellido"].Value = _usuarioDto.Apellido;
                //  row.Cells["telefono"].Value = _usuarioDto.Telefono;
                //  row.Cells["celular"].Value = _usuarioDto.Celular;
                //  row.Cells["correo"].Value = _usuarioDto.Correo;
                //  row.Cells["ciudad"].Value = _usuarioDto.IdCiudad;
                //  row.Cells["direccion"].Value = _usuarioDto.Direccion;
                //  row.Cells["usuario"].Value = _usuarioDto.Usuario;
                //  row.Cells["rol"].Value = _usuarioDto.IdRol;
                List<UsuarioDto> list = new List<UsuarioDto>();//await _usuarioService.ObtenerUsuarioAsync();// ObtenerUsuarioAsync(cedula);
                dtgUsuario.Rows.Clear();

                int cont = 0;

                foreach (UsuarioDto us in list)
                {
                    dtgUsuario.Rows.Add(1);
                    dtgUsuario.Rows[cont].Cells[0].Value = us.Id.ToString();
                    dtgUsuario.Rows[cont].Cells[1].Value = us.Cedula.ToString();
                    dtgUsuario.Rows[cont].Cells[2].Value = us.Nombre.ToString();
                    dtgUsuario.Rows[cont].Cells[3].Value = us.Apellido.ToString();
                    dtgUsuario.Rows[cont].Cells[4].Value = us.Telefono.ToString();
                    dtgUsuario.Rows[cont].Cells[5].Value = us.Celular.ToString();
                    dtgUsuario.Rows[cont].Cells[6].Value = us.Correo.ToString();
             //       dtgUsuario.Rows[cont].Cells[7].Value = us.Ciudad.Descripcion.ToString();
                    dtgUsuario.Rows[cont].Cells[8].Value = us.Direccion.ToString();
               //     dtgUsuario.Rows[cont].Cells[9].Value = us.User.ToString();
                //    dtgUsuario.Rows[cont].Cells[10].Value = us.Rol.RolUsuario.ToString();

                    cont++;
                }
                pnlRegUss.Visible = false;
                pnlMuser.Visible = false;
                pnlLisUss.Visible = true;
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await LlenarComboBoxRoles();
            await LlenarComboBoxCiudades();
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
                    string genero = cmbGenero.Texts.Trim();
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
                //int id = 0;
                //int idciudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                //int idrol = Convert.ToInt32(cbRol.SelectedValue);
                //string cedula = txtCedula.Text, nombre = txtCedula.Text, apellido = txtApellido.Text, genero = cmbGenero.Text.Trim(),
                //       telefono = txtTelefono.Text, celular = txtCelular.Text, correo = txtCorreo.Text, direccion = txtDireccion.Text,
                //       usuario = txtUsuario.Text, clave = txtClave.Text;
                //BorrarAlerta();
                //try
                //{
                //    if (validar())
                //    {
                //        Usuario us = new Usuario(id, cedula, nombre, apellido, genero, telefono, celular, correo, direccion, idciudad, idrol, usuario, clave);
                //        usuarioDao.InsertUsuario(us);
                //        Limpiar();
                //    }
                //}
                //catch (ExceptionSistema ex)
                //{
                //    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

        }
        private bool validar()
        {
           // Validation valida = new Validacionp();
            bool campo = true;
            if (txtCedula.Text =="")
            {
                campo = false;
                errorProvider1.SetError(txtCedula, "Se esperaba 10 numeros.");
            }
            if (txtNombre.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtNombre, "Ingrese un nombre completo.");
            }
            if (txtApellido.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtNombre, "Ingrese un apellido completo.");
            }
            if (txtTelefono.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
            }
            if (txtCelular.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtCelular, "Se esperaba 10 numeros");
            }
            if (cmbGenero.SelectedIndex < 0)
            {
                campo = false;
                errorProvider1.SetError(cmbGenero, "Selecione un tipo de genero.");
            }
            if (cmbCiudad.SelectedIndex < 0)
            {
                campo = false;
                errorProvider1.SetError(cmbCiudad, "Selecione una ciudad.");
            }
            if (cbRol.SelectedIndex < 0)
            {
                campo = false;
                errorProvider1.SetError(cbRol, "Selecione un tipo de rol.");
            }
            if (txtCorreo.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
            }
            if (txtClave.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtClave, "Ingrese una contraseña.");
            }
            if (txtDireccion.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtDireccion, "Ingrese una direccion.");
            }
            if (txtUsuario.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtUsuario, "Ingrese un usuario.");
            }
            if (!campo)
            {
                throw new ExceptionSistema("Datos no validos!");
            }
            return campo;
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
        public void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgUsuario.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgUsuario.Columns.Count)
                {
                    if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value);
                                txtMcedula.Text = dtgUsuario.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
                                txtMnombre.Text = dtgUsuario.Rows[e.RowIndex].Cells["name"].Value.ToString();
                                txtMapellido.Text = dtgUsuario.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                                txtMtelefono.Text = dtgUsuario.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                                txtMCelular.Text = dtgUsuario.Rows[e.RowIndex].Cells["celu"].Value.ToString();
                                txtMcorreo.Text = dtgUsuario.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                                cmbMciudad.Texts = dtgUsuario.Rows[e.RowIndex].Cells["ciudad"].Value.ToString();
                                txtMdireccion.Text = dtgUsuario.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                                txtMusuario.Text = dtgUsuario.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                                cmbMrol.Texts = dtgUsuario.Rows[e.RowIndex].Cells["rol"].Value.ToString();
                                pnlRegUss.Visible = false;
                                pnlMuser.Visible = true;
                                pnlLisUss.Visible = false;
                              //  cmbMtipemp.Click += new EventHandler(cmbMtipemp_Click_1);

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgUsuario.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value);
                            //u.EliminarUsuario(Id);
                            //llenarDatagrid("");
                        }

                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbaddU_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible=true;
            pnlMuser.Visible=false;
            pnlLisUss.Visible=false;
        }

        private void ptbvolver_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible = false;
            pnlMuser.Visible = false;
            pnlLisUss.Visible = true;
        }

        private void ptbMvolver_Click(object sender, EventArgs e)
        {
            pnlRegUss.Visible = false;
            pnlMuser.Visible = false;
            pnlLisUss.Visible = true;
        }

        private void btnActualizarus_Click(object sender, EventArgs e)
        {
            // Id=us.Id;
            String cedula = txtMcedula.Text, nombre = txtMnombre.Text, apellido = txtMapellido.Text, telefono = txtMtelefono.Text,
                celular = txtMCelular.Text, correo = txtMcorreo.Text, user = txtMusuario.Text, direccion = txtMdireccion.Text;
            if (!String.IsNullOrEmpty(txtMcedula.Text))
            {
                //u.ActualizarDatos(Id, cedula, nombre, apellido, telefono, celular, correo, direccion, user);
                //MessageBox.Show("Datos actualizados");
                //llenarDatagrid("");
                pnlRegUss.Visible = false;
                pnlMuser.Visible = false;
                pnlLisUss.Visible = true;

            }
        }

        private void txtBuscarUs_TextChanged(object sender, EventArgs e)
        {
          //  llenarDatagrid(txtBuscarUs.Text);
        }
    }
}
