///using LogicDeNegocio.personas;
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


namespace Presentacion.ModuloEmpresa
{
    public partial class FrmTipoEmpresa : Form
    {
        private readonly ITipoEmpresaService _tipoEmpresaService;

        int Id;
        public FrmTipoEmpresa(ITipoEmpresaService tipoEmpresaService)
        {
            _tipoEmpresaService = tipoEmpresaService;
            InitializeComponent();
            this.Load += new EventHandler(FrmTipoEmpresa_Load);
        }

        private async void LlenarDataGrid(string dato)
        {
            try
            {
                List<TipoEmpresaDto> list = await _tipoEmpresaService.ObtenerTipoEmpresas(dato);
                dtgTipEmpresa.Rows.Clear();

                int cont = 0;

                foreach (TipoEmpresaDto t in list)
                {
                    dtgTipEmpresa.Rows.Add(1);
                    dtgTipEmpresa.Rows[cont].Cells[0].Value = t.Id.ToString();
                    dtgTipEmpresa.Rows[cont].Cells[1].Value = t.Descripcion.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void btnGuardartipEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // temp.InsertarTipEmpresa(temp);
                    TipoEmpresaRequest tipo = new TipoEmpresaRequest()
                    { Codigo = txtTipempresa.Text, Descripcion = txtTipempresa.Text };
                    await _tipoEmpresaService.RegistrarTipoEmpresa(tipo);
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
        private void FrmTipoEmpresa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
        }

        private bool Validar()
        {
            bool campo = true;
            if (txtTipempresa.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtTipempresa, "Ingrese un tipo de empresa");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtTipempresa.Text = "";
        }

        private async void dtgTipEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgTipEmpresa.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgTipEmpresa.Columns.Count)
                {
                    if (dtgTipEmpresa.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgTipEmpresa.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgTipEmpresa.Rows[e.RowIndex].Cells["idtipo"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgTipEmpresa.Rows[e.RowIndex].Cells["idtipo"].Value);
                                txtMtipemp.Text = dtgTipEmpresa.Rows[e.RowIndex].Cells["tipemp"].Value.ToString();
                                pnlRegistrotip.Visible = false;
                                pnlModificatipo.Visible = true;
                                

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgTipEmpresa.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgTipEmpresa.Rows[e.RowIndex].Cells["idtipo"].Value);
                            await _tipoEmpresaService.EliminarTipoEmpresa(Id);
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

        private async void btnActualizarTE_Click(object sender, EventArgs e)
        {
            string tipo = txtMtipemp.Text;
            if (!String.IsNullOrEmpty(txtMtipemp.Text))
            {
                TipoEmpresaRequest tipoEmpresa = new TipoEmpresaRequest()
                {
                    Descripcion = tipo
                };
                await _tipoEmpresaService.ActualizarTipoEmpresa(Id, tipoEmpresa);
                MessageBox.Show("Datos actualizados con exito.");
                pnlRegistrotip.Visible = true;
                pnlModificatipo.Visible = false;
                LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }

        private void txtBtipemp_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipempresa.Text);
        }

        private void btnBuscartemp_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipempresa.Text);
        }

       
    }
}
