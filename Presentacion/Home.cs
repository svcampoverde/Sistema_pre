using MaterialSkin;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloProducto;
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
            Frmdi.OpenChildForm(new FrmEmpresa());
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
            Frmdi.OpenChildForm(new FrmCategoria());
        }
    }
}
