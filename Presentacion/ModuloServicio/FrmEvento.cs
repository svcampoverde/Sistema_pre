using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloServicio
{
    public partial class FrmEvento : Form
    {
        private readonly IEventoService _eventoService;
        public FrmEvento(IEventoService eventoService)
        {
            _eventoService = eventoService;
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private async void btnGuardarevento_Click(object sender, EventArgs e)
        {
            EventoRequest eventoRequest = new EventoRequest()
            {
                Descripcion = txtlocalevento.Text,
                FechaEvento = Convert.ToDateTime(txtdateevento.Text),
                Promotor = txtPromotor.Text,
                Artista = txtArtista.Text,
                // IdCiudad=
            };
            await _eventoService.RegistrarEvento(eventoRequest);
            LimpiarCampos();
            MessageBox.Show("Evento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimpiarCampos()
        {
            txtdateevento.Text = string.Empty;
            txtlocalevento.Text = string.Empty;
            txtPromotor.Text = string.Empty;
            txtArtista.Text = string.Empty;
        }
    }
}
