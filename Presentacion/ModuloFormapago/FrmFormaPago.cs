using DevComponents.DotNetBar.Validator;
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

namespace Presentacion.ModuloPago
{
    public partial class FrmFormaPago : Form
    {
        private readonly IFormaPagoService _service;
        int Id;
        public FrmFormaPago(IFormaPagoService formaPago)
        {
            _service = formaPago;
            InitializeComponent();
        }
        private async void LlenarDataGrid(string dato)
        {
            try
            {
                List<FormaPagoDto> list = await _service.ObtenerListForPage(dato);
                dtgFormapago.Rows.Clear();

                int cont = 0;

                foreach (FormaPagoDto services in list)
                {
                    dtgFormapago.Rows.Add(1);
                    dtgFormapago.Rows[cont].Cells[0].Value = services.Id.ToString();
                    dtgFormapago.Rows[cont].Cells[1].Value = services.Nombre.ToString();
                    dtgFormapago.Rows[cont].Cells[2].Value = services.Descripcion.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtBformapag_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBformapag.Text);
        }

        private async void btnGuardarfpago_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    FormaPagoRequest forma = new FormaPagoRequest()
                    {
                        Codigo = txtfpago.Text,
                        Nombre = txtfpago.Text,
                        Descripcion = txtfpDescrpcion.Text,
                    };
                    await _service.RegistrarFormaPago(forma);

                    MessageBox.Show("Registro realizado con éxito");
                    LimpiarCampos();
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
            if (txtfpago.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtfpago, "Ingrese una especificación de forma de pago");
            }
            if(txtfpDescrpcion.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtMfpago, "Ingrese una especificación de forma de pago");
            }
            return campo;
        }
        private void LimpiarCampos() 
        {
            txtfpago.Text = string.Empty;
            txtfpDescrpcion.Text = string.Empty;
        }
        private async void dtgFormapago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgFormapago.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgFormapago.Columns.Count)
                {
                    if (dtgFormapago.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgFormapago.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgFormapago.Rows[e.RowIndex].Cells["idfpago"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgFormapago.Rows[e.RowIndex].Cells["idfpago"].Value);
                                txtMfpago.Text = dtgFormapago.Rows[e.RowIndex].Cells["fpago"].Value.ToString();
                                txtMfpdescripcion.Text = dtgFormapago.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                                pnlListFpago.Visible = false;
                                pnlMfpago.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgFormapago.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgFormapago.Rows[e.RowIndex].Cells["idfpago"].Value);
                            await _service.EliminarFormaPago(Id);
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

        private async void btnMfpago_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMfpago.Text) || !String.IsNullOrEmpty(txtMfpdescripcion.Text))
            {
                var request = new FormaPagoRequest
                {
                    Nombre = txtMfpago.Text,
                    Descripcion = txtMfpdescripcion.Text,
                  
                };
                await _service.ActualizarFormaPago(Id, request);
                MessageBox.Show("Datos actualizados con exito.");
                pnlMfpago.Visible = false;
                pnlListFpago.Visible = true;
                LlenarDataGrid("");
            }
        }

        private void ptbaddfpago_Click(object sender, EventArgs e)
        {
            pnlRegfPago.Visible = true;
            pnlListFpago.Visible=false;
        //    pnlMfpago.Visible = false;
        }

        private void ptbrfpago_Click(object sender, EventArgs e)
        {
            pnlRegfPago.Visible = false;
            pnlListFpago.Visible = true;
            pnlMfpago.Visible = false;
        }

        private void ptbMfpago_Click(object sender, EventArgs e)
        {
            pnlRegfPago.Visible = false;
            pnlListFpago.Visible = true;
            pnlMfpago.Visible = false;
        }

        private void btnBformapag_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBformapag.Text);
        }

        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
        }
    }
}
