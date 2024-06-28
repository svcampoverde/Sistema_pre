using LogicDeNegocio;
using LogicDeNegocio.personas;
using LogicDeNegocio.provincia;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmRegistrarUsuario : MaterialSkin.Controls.MaterialForm
    {
        AdmRol adm = new AdmRol();
        UsuarioDao usuarioDao = new UsuarioDao();
        Ciudad ciud = new Ciudad();
        Rol r = new Rol();
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            llenarCombobox();
        }
        private void llenarCombobox()
        {
            try { 
                List<Rol> list = r.llenarComboRol();

                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No se encontraron roles para cargar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cbRol.DataSource = null;
                cbRol.DataSource = list;
                cbRol.DisplayMember = "RolUsuario";
                cbRol.ValueMember = "Idrol";
            }
            catch(ExceptionSistema ex)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idciudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            int idrol = Convert.ToInt32(cbRol.SelectedValue);
            string cedula = txtCedula.Text, nombre = txtCedula.Text, apellido = txtApellido.Text, genero = cmbGenero.Text.Trim(), 
                   telefono = txtTelefono.Text, celular = txtCelular.Text, correo = txtCorreo.Text, direccion = txtDireccion.Text,
                   usuario = txtUsuario.Text, clave = txtClave.Text;
            BorrarAlerta();
            try
            {
                if (validar())
                {
                    Usuario us = new Usuario(cedula, nombre, apellido, genero, telefono, celular, correo, direccion, idciudad, idrol, usuario, clave);
                    usuarioDao.InsertUsuario(us);
                    Limpiar();
                }
            }
            catch(ExceptionSistema ex) 
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
         private bool validar()
        {
            Validacionp valida = new Validacionp();
            bool campo = true;
            if (valida.ValidarCedula(txtCedula.Text) != true)
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
            if (valida.ValidarTelefono(txtTelefono.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
            }
            if(valida.ValidarCelular(txtCelular.Text) != true)
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
            if (valida.validarEmail(txtCorreo.Text) != true)
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
                List<Ciudad> list = ciud.llenarComboCiudad();
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No se encontraron provincias para cargar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmbCiudad.DataSource = null;
                cmbCiudad.DataSource = list;
                cmbCiudad.DisplayMember = "Descripcion";
                cmbCiudad.ValueMember = "Idciudad";

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
