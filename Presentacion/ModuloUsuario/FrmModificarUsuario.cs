//using LogicDeNegocio.personas;
using LogicDeNegocio.Interfaces;

using System;
using System.Windows.Forms;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmModificarUsuario : Form
    {

        private readonly IUsuarioService _usuarioService;
        private int id;
        public FrmModificarUsuario(IUsuarioService usuarioService)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmModificarUsuario_Load);
            _usuarioService = usuarioService;
            // ObtenerDatos(id);
        }
        public void SetIdUsuario(int id)
        {
            this.id = id;
            MessageBox.Show("usuario");
        }

        //private void ObtenerDatos(int idUsuario)
        //{
        //    List<NombreUsuario> user = us.BuscarDatos(idUsuario);
        //    foreach (NombreUsuario usuario in user)
        //    {
        //        txtCedula.Text = usuario.Cedula;
        //        txtNombre.Text = usuario.Nombre;
        //        txtApellido.Text = usuario.Apellido;
        //        cmbGenero.SelectedValue = usuario.Genero;
        //        txtTelefono.Text = usuario.Telefono;
        //        txtCelular.Text = usuario.Celular;
        //        txtCorreo.Text = usuario.Correo;
        //        txtDireccion.Text = usuario.Direccion;
        //       // cmbCiudad.SelectedValue = usuario.Ciudad.Descripcion;

        //        //cbRol.SelectedValue = usuario.Rol.RolUsuario;
        //        txtUsuario.Text = usuario.User;
        //    }


        //}


        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

    }
}
