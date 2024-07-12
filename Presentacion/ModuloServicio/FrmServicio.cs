//using LogicDeNegocio.personas;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using LogicDeNegocio.Servicio;


namespace Presentacion.ModuloServicio
{
    public partial class FrmServicio : Form
    {
        private readonly ITipoServicioService _tiposervicioService;
        int Id;
        public FrmServicio(ITipoServicioService tiposervicio)
        {
            _tiposervicioService = tiposervicio;
            InitializeComponent();
            this.Load += new EventHandler(FrmServicio_Load);
        }
        private async void LlenarDataGrid(string datos)
        {
            try
            {
                List<TipoServicioDto> list = await _tiposervicioService.ObtenerListServicio(datos);
                dtgServicio.Rows.Clear();

                int cont = 0;

                foreach (TipoServicioDto services in list)
                {
                    dtgServicio.Rows.Add(1);
                    dtgServicio.Rows[cont].Cells[0].Value = services.Id.ToString();
                    dtgServicio.Rows[cont].Cells[1].Value = services.Descripcion.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmServicio_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
        }

        private async void brnGuardarS_Click(object sender, EventArgs e)
        {
            // adms.Descripcion = txtServicio.Text;
            try
            {
                if (Validar())
                {
                    TipoServicioRequest servicio = new TipoServicioRequest()
                    {Codigo=txtServicio.Text, Descripcion=txtServicio.Text};
                    await _tiposervicioService.RegistrarTipoServicio(servicio);
                    MessageBox.Show("Registro de servicio realizado con éxito");
                    Limpiar();
                    LlenarDataGrid("");
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validar()
        {
            bool campo = true;
            if (txtServicio.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtServicio, "Ingrese una especificación de sercio");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtServicio.Text = "";
        }

        private void txtBservicio_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBservicio.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBservicio.Text);
        }

        private async void dtgServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgServicio.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgServicio.Columns.Count)
                {
                    if (dtgServicio.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgServicio.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgServicio.Rows[e.RowIndex].Cells["idservicio"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgServicio.Rows[e.RowIndex].Cells["idservicio"].Value);
                                txtMservicio.Text = dtgServicio.Rows[e.RowIndex].Cells["servicio"].Value.ToString();
                                pnlRegistroservicio.Visible = false;
                                pnlModificaservicio.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgServicio.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgServicio.Rows[e.RowIndex].Cells["idservicio"].Value);
                            await _tiposervicioService.EliminarTipoServicio(Id);
                            // adms.EliminarServicio(Id);
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

        private async void btnActualizarS_Click(object sender, EventArgs e)
        {
            string servi = txtMservicio.Text;
            if (!String.IsNullOrEmpty(txtMservicio.Text))
            {
                TipoServicioRequest tiposervicio = new TipoServicioRequest() { Id = Id,  Descripcion = servi };
              
                await _tiposervicioService.ActualizarTipoServicio(Id, tiposervicio);
                MessageBox.Show("Datos actualizados con exito.");
                pnlModificaservicio.Visible = false;
                pnlRegistroservicio.Visible = true;
                LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }
    }
}
