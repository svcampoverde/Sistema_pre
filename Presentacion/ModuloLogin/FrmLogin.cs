
using Datos.AplicationDB;
using MaterialSkin;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.ModuloLogin
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        private readonly SistemapContext _sistemapContext;

        public FrmLogin(SistemapContext sistemapContext)
        {
            InitializeComponent();
            _sistemapContext = sistemapContext;
        }

        private void Login_Load(object sender, EventArgs e)
        {

            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            try
            {
                if (validarUs())
                {
                    // Se hace uso del control de excepciones conde se llama a la clase ControlExcepcion, si el usuario no ingresa las credenciales 
                    try
                    {
                        ConsultarCre(user, clave);
                    }
                    catch (Exception ex)
                    {
                        // Se envia un aviso indicando que sus credenciales no son las correctas
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ConsultarCre(string user, string clave)
        {
            //usuarioDao = new UsuarioDao();
            //bool credencialV = usuarioDao.ValidarCredencial(user, clave);
            // bool us = usuarioDao.ValidarUsuario(user);

            //if (credencialV)
            //{
            //    //  MessageBox.Show("NombreUsuario bienvenido");
            //    this.Hide();
            //    FRMPrincipal obj = new FRMPrincipal();
            //    obj.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("NombreUsuario o contraseña incorrecta");
            //}
        }
        private void valUser(string user)
        {

            //bool userexit = usuarioDao.ValidarUsuario(user);
            var userexit = _sistemapContext.Usuarios.Any(u => u.NombreUsuario == user);

            if (userexit)
            {
                this.Hide();
                FrmRecuperarContrasena ob = new FrmRecuperarContrasena();
                ob.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
        }
        private bool validarUs()
        {
            bool res = true;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                res = false;
                errorProvider1.SetError(txtUsuario, "Ingrese el usuario");
            }
            else
            {
                errorProvider1.Clear();
            }
            return res;
        }

        private void lbRecupera_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();

            try
            {
                if (validarUs())
                {
                    try
                    {
                        valUser(user);
                    }
                    catch (Exception ex)
                    {
                        // Se envia un aviso indicando que sus credenciales no son las correctas
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chMostrar.Checked)
            {
                txtClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
            }

        }

        /* private void ConsultaLoginBD(string correo, string password)
        {

            List<int> IdPeronsaAndRol = usuarioDao.Credenciales(correo, password);
            int rol = IdPeronsaAndRol[0];
            if (rol != 0)
            {
                txtUsuario.Text = null;
                txtClave.Text = null;
               // Program.prueba.Hide();
                switch (rol)
                {
                    case 1:
                        int Idpersona = IdPeronsaAndRol[1];
                        Principal ventanaAdministrador = new Principal(Idpersona);
                        ventanaAdministrador.ShowDialog();
                        break;
                }
            }
        }*/

    }
}
