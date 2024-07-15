using LogicDeNegocio.Dtos;
using LogicDeNegocio;
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
using DevComponents.DotNetBar.Validator;
using LogicDeNegocio.Requests;

namespace Presentacion.ModuloProducto
{
    public partial class FrmTipoProducto : Form
    {
        private readonly ITipoProductoService _service;
        int Id;
        public FrmTipoProducto(ITipoProductoService service)
        {
            this._service = service;
            InitializeComponent(); 
        }

        private async void LlenarDataGrid(string dato)
        {
            try
            {
                List<TipoProductoDto> list = await _service.ObtenerTipoProducto(dato);
                dtgTipProducto.Rows.Clear();

                int cont = 0;

                foreach (TipoProductoDto t in list)
                {
                    dtgTipProducto.Rows.Add(1);
                    dtgTipProducto.Rows[cont].Cells[0].Value = t.Id.ToString();
                    dtgTipProducto.Rows[cont].Cells[1].Value = t.Descripcion.ToString();
                    cont++;
                }
                pnlListiproducto.Visible = true;

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validar()
        {
            bool campo = true;
            if (txtipproducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtipproducto, "Ingrese un tipo de producto");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtipproducto.Text = "";
        }

        private async void btnGuarTipoproducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    TipoProductoRequest tipo = new TipoProductoRequest()
                    { Codigo = txtipproducto.Text, Descripcion = txtipproducto.Text };
                    await _service.RegistrarTipoProducto(tipo);
                    MessageBox.Show("Registro realizado con éxito");
                    Limpiar();
                    LlenarDataGrid("");
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dtgTipProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgTipProducto.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgTipProducto.Columns.Count)
                {
                    if (dtgTipProducto.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgTipProducto.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgTipProducto.Rows[e.RowIndex].Cells["idtiproducto"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgTipProducto.Rows[e.RowIndex].Cells["idtiproducto"].Value);
                                txtMtiprocuto.Text = dtgTipProducto.Rows[e.RowIndex].Cells["tipproducto"].Value.ToString();
                                pnlRtiproducto.Visible = false;
                                pnlMtiproducto.Visible = true;
                                pnlListiproducto.Visible = false;


                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgTipProducto.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgTipProducto.Rows[e.RowIndex].Cells["idtiproducto"].Value);
                            //temp.EliminarTipempresa(Id);
                            await _service.EliminarTipoProducto(Id);
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

        private async void btnMtiproducto_Click(object sender, EventArgs e)
        {
          //  string tipo = txtMtipemp.Text;
            if (!String.IsNullOrEmpty(txtMtiprocuto.Text))
            {
                TipoProductoRequest tipoEmpresa = new TipoProductoRequest()
                {
                    Descripcion = txtMtiprocuto.Text
                };
                await _service.ActualizarTipoProducto(Id, tipoEmpresa);
                MessageBox.Show("Datos actualizados con exito.");
                pnlRtiproducto.Visible = true;
                pnlMtiproducto.Visible = false;
                LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }

        private void FrmTipoProducto_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
        }

        private void txtBtipoproducto_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipoproducto.Text);
        }
        private void btnBuscartipoproducto_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipoproducto.Text);
        }

        private void ptbRtiproducto_Click(object sender, EventArgs e)
        {
            pnlListiproducto.Visible = false;
            pnlRtiproducto.Visible = true;
        }

        private void ptbMtproducto_Click(object sender, EventArgs e)
        {
            pnlListiproducto.Visible=true;
            pnlMtiproducto.Visible = false;
        }

        private void ptbRtproducto_Click(object sender, EventArgs e)
        {
            pnlListiproducto.Visible=true;
            pnlRtiproducto.Visible=false;
        }
    }
}
