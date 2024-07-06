//using LogicDeNegocio.personas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloUsuario
{
    public partial class btnActualizar : Form
    {
       // Usuario us = new Usuario();
        //int id;
        public btnActualizar(int id)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmModificarUsuario_Load);
            
            MessageBox.Show("Idusuario" + id);
           // ObtenerDatos(id);
        }
        //private void ObtenerDatos(int idUsuario)
        //{
        //    List<Usuario> user = us.BuscarDatos(idUsuario);
        //    foreach (Usuario usuario in user)
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
