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
using Unity;

namespace Presentacion
{
    public partial class Home : Form
    {
        FrmIPrincipal Frmdi;
        private IUnityContainer _container;
        public Home(IUnityContainer container, FrmIPrincipal mdip)
        {
            InitializeComponent();
            this.Load += new EventHandler(Home_Load);
            this.Frmdi = mdip;
            this._container = container;
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
            var form = _container.Resolve<FrmEmpresa>();
            Frmdi.OpenChildForm(form);
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
            var form = _container.Resolve<FrmCategoria>();
            Frmdi.OpenChildForm(form);
        }

        private void ptbproveedor_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = _container.Resolve<FrmRegistroProveedor>();
            Frmdi.OpenChildForm(form);
        }

        private void ptbICliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = _container.Resolve<FrmRegistrarCliente>();
            Frmdi.OpenChildForm(form);
        }

        private void ptempleado_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = _container.Resolve<FrmEmpleado>();
            Frmdi.OpenChildForm(form);
        }
        
        private void ptbIproducto_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = _container.Resolve<FrmInventario>();
            Frmdi.OpenChildForm(form);
        }
    }
}
