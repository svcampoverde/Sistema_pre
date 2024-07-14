using Datos.Models;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
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
        private readonly ICiudadService _ciudadService;
        int Id;
        public FrmEvento(IEventoService eventoService, ICiudadService ciudadService)
        {
            _eventoService = eventoService;
            _ciudadService = ciudadService ?? throw new ArgumentNullException(nameof(ciudadService));
            InitializeComponent();
            
        }
        private async Task LlenarComboBoxCiudades()
        {
            try
            {
                var ciudades = await _ciudadService.obtenerCiudades();
                if (ciudades.Any())
                {
                    cmbCiudadevento.DataSource = ciudades;
                    cmbCiudadevento.DisplayMember = "Nombre";
                    cmbCiudadevento.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LlenarDataGrid(string dato)
        {
            try
            {
                List<EventoDto> list = await _eventoService.ObtenerListEvent(dato);
                dtgEvento.Rows.Clear();

                int cont = 0;

                foreach (EventoDto evento in list)
                {
                    dtgEvento.Rows.Add(1);
                    dtgEvento.Rows[cont].Cells[0].Value = evento.Id.ToString();
                    dtgEvento.Rows[cont].Cells[1].Value = evento.FechaEvento.ToString();
                    dtgEvento.Rows[cont].Cells[2].Value= evento.Nombre.ToString();
                    dtgEvento.Rows[cont].Cells[3].Value = evento.Descripcion.ToString();
                    dtgEvento.Rows[cont].Cells[4].Value = evento.Artista.ToString();
                    dtgEvento.Rows[cont].Cells[5].Value = evento.Promotor.ToString();
                    dtgEvento.Rows[cont].Cells[6].Value = evento.Direccion.ToString();
                    dtgEvento.Rows[cont].Cells[7].Value = evento.IdCiudad.ToString();
                    cont++;
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void FrmEvento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await Task.WhenAll(LlenarComboBoxCiudades());
            LlenarDataGrid("");
        }

        private async void btnGuardarevento_Click(object sender, EventArgs e)
        {
            EventoRequest eventoRequest = new EventoRequest()
            {
                Nombre =txtRevento.Text,
                Descripcion = txtlocalevento.Text,
                FechaEvento = Convert.ToDateTime(txtdateevento.Text),
                Promotor = txtPromotor.Text,
                Artista = txtArtista.Text,
                Direccion = txtlocalevento.Text, 
                IdCiudad= Convert.ToInt32(cmbCiudadevento.SelectedValue),
            };
            await _eventoService.RegistrarEvento(eventoRequest);
            LimpiarCampos();
            MessageBox.Show("Evento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlRegistroevento.Visible = false;
            pnlListEvento.Visible = true;
            LlenarDataGrid("");

        }
        private void LimpiarCampos()
        {
            txtRevento.Text = string.Empty;
            txtdateevento.Text = string.Empty;
            txtlocalevento.Text = string.Empty;
            txtPromotor.Text = string.Empty;
            txtArtista.Text = string.Empty;
            txtlocalevento.Text = string.Empty;
            cmbCiudadevento.SelectedIndex = -1;
        }

        private void ptbaddevento_Click(object sender, EventArgs e)
        {
            pnlRegistroevento.Visible=true;
            pnlListEvento.Visible=false;
        }

        private async void dtgEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgEvento.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgEvento.Columns.Count)
                {
                    if (dtgEvento.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgEvento.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgEvento.Rows[e.RowIndex].Cells["idevento"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgEvento.Rows[e.RowIndex].Cells["idevento"].Value);
                                txtMdtevento.Text = dtgEvento.Rows[e.RowIndex].Cells["fecha"].Value.ToString();
                                txtMNevento.Text = dtgEvento.Rows[e.RowIndex].Cells["evento"].Value.ToString();
                                txtMdescripevento.Text = dtgEvento.Rows[e.RowIndex].Cells["namevento"].Value.ToString();
                                txtMartistaevent.Text = dtgEvento.Rows[e.RowIndex].Cells["artista"].Value.ToString();
                                txtMpromotor.Text = dtgEvento.Rows[e.RowIndex].Cells["promotor"].Value.ToString();
                                txtMlocalevento.Text = dtgEvento.Rows[e.RowIndex].Cells["local"].Value.ToString();
                              //  cmbMciudevento.Texts = dtgEvento.Rows[e.RowIndex].Cells["ciu"].Value.ToString();
                                pnlListEvento.Visible = false;
                                pnlMevento.Visible = true;
                                cmbMciudevento.Visible = false;
                                labelEdit16.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgEvento.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgEvento.Rows[e.RowIndex].Cells["idevento"].Value);
                            await _eventoService.EliminarEvento(Id);
                            LlenarDataGrid("");
                        }

                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnMactevento_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMNevento.Text))
            {
                var request = new EventoRequest
                {
                    Nombre = txtMNevento.Text,
                    Descripcion = txtMdescripevento.Text,
                    FechaEvento = Convert.ToDateTime(txtMdtevento.Text),
                    Artista = txtMartistaevent.Text,
                    Promotor = txtMpromotor.Text,
                    Direccion = txtMlocalevento.Text,
                };
                await _eventoService.ActualizarEvento(Id, request);
                MessageBox.Show("Datos actualizados con exito.");
                pnlMevento.Visible = false;
                pnlListEvento.Visible = true;
                LlenarDataGrid("");
            }
        }

        private void ptbIMevento_Click(object sender, EventArgs e)
        {
            pnlListEvento.Visible = true;
            pnlMevento.Visible = false;
        }

        private void ptbIRevento_Click(object sender, EventArgs e)
        {
            pnlListEvento.Visible=true;
            pnlRegistroevento.Visible=false;
        }

    }
}
