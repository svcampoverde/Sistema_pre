using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
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
        private readonly IEventoService _eventoService;
        public FrmRegistrarPresupuesto(IEventoService eventoService)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmRegistrarPresupuesto_Load);
            _eventoService = eventoService;
        }

        private void FrmRegistrarPresupuesto_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void autoCompletar(string search)
        {

        }

        
    }
}
