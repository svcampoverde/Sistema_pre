using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloPresupuesto
{
    public partial class FrmRegistrarPresupuesto : Form
    {
        public FrmRegistrarPresupuesto()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmRegistrarPresupuesto_Load);
        }

        private void FrmRegistrarPresupuesto_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        
    }
}
