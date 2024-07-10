using MaterialSkin;
using Presentacion.ModuloCliente;
using Presentacion.ModuloEmpleado;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloProducto;
using Presentacion.ModuloProveedor;
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
    public partial class Home : Form
    {
        FrmIPrincipal Frmdi;

        public Home(FrmIPrincipal mdip)
        {
            InitializeComponent();
            this.Load += new EventHandler(Home_Load);
            this.Frmdi = mdip;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void ptbempresa_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmEmpresa>();
        }
        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void ptbCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmCategoria>();
        }

        private void ptbproveedor_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmRegistroProveedor>();
        }

        private void ptbICliente_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmRegistrarCliente>();
        }

        private void ptempleado_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmEmpleado>();
        }
        
        private void ptbIproducto_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm< FrmInventario> ();
        }
    }
}
