using MaterialSkin;
using Presentacion.ModuloLogin;
using Presentacion.ModuloProvincia;
using Presentacion.ModuloRolusuario;
using Presentacion.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FRMPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FRMPrincipal()
        {
            InitializeComponent();
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void Prueba_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
            cbUsuario.BackColor = Color.Red;

            // Set background color in code
            cbUsuario.BackColor = Color.FromArgb(255, 128, 128);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.PanelContent.Controls.Clear();
            FrmRegistrarUsuario Frm = new FrmRegistrarUsuario();
            Frm.TopLevel = false;
            PanelContent.Controls.Add(Frm);
            Frm.Show();

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRegistrarUsuario Frm = new FrmRegistrarUsuario();
            //Frm.TopLevel = false;
            //mtControl.Controls.Add(Frm);
            //Frm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.PanelContent.Controls.Clear();
            BuscarUsuario Frm = new BuscarUsuario();
            Frm.TopLevel = false;
            PanelContent.Controls.Add(Frm);
            Frm.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.PanelContent.Controls.Clear();
            Home Frm = new Home();
            Frm.TopLevel = false;
            PanelContent.Controls.Add(Frm);
            Frm.Show();
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbUsuario.SelectedIndex)
            {
                case 0:
                    this.PanelContent.Controls.Clear();
                    BuscarUsuario Frm = new BuscarUsuario();
                    Frm.TopLevel = false;
                    PanelContent.Controls.Add(Frm);
                    Frm.Show();
                    break;
                case 1:
                    Registrar();
                    break;
                    
            }

        }

        private void Registrar()
        {
            if(cbUsuario.SelectedIndex == 1){
                this.PanelContent.Controls.Clear();
                FrmRegistrarUsuario Frm = new FrmRegistrarUsuario();
                Frm.TopLevel = false;
                PanelContent.Controls.Add(Frm);
                Frm.Show();
            }
           
        
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProvincia.SelectedIndex)
            {
                case 0:
                    this.PanelContent.Controls.Clear();
                    FrmBuscarProvincia Frm = new FrmBuscarProvincia();
                    Frm.TopLevel = false;
                    PanelContent.Controls.Add(Frm);
                    Frm.Show();
                    break;
                case 1:
                    RegistrarProv();
                    break;
            }

        }
        private void RegistrarProv()
        {
            if (cbProvincia.SelectedIndex == 1)
            {
                this.PanelContent.Controls.Clear();
                FrmProvincia Frm = new FrmProvincia();
                Frm.TopLevel = false;
                PanelContent.Controls.Add(Frm);
                Frm.Show();
            }
        }

        private void cbRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRolUsuario.SelectedIndex)
            {
                case 0:
                    this.PanelContent.Controls.Clear();
                    BuscarRol Frm = new BuscarRol();
                    Frm.TopLevel = false;
                    PanelContent.Controls.Add(Frm);
                    Frm.Show();
                    break;
                case 1:
                    RegistrarRol();
                    break;
            }
        }
        private void RegistrarRol()
        {
            if (cbRolUsuario.SelectedIndex == 1)
            {

                this.PanelContent.Controls.Clear();
                FRMRol Frm = new FRMRol();
                Frm.TopLevel = false;
                PanelContent.Controls.Add(Frm);
                Frm.Show();
            }
        }
    }
}
