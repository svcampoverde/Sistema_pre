//using LogicDeNegocio.personas;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using LogicDeNegocio.producto;


namespace Presentacion.ModuloProducto
{
    public partial class FrmCategoria : Form
    {
        private readonly ICategoriaProductoService _categoriaProductoService;
        int Id;
        public FrmCategoria(ICategoriaProductoService categoriaProductoService)
        {
            _categoriaProductoService = categoriaProductoService;
            InitializeComponent();
            this.Load += new EventHandler(FrmCategoria_Load);
        }
        private async void LlenarDataGrid(string datos)
        {
            try
            {
                List<CategoriaProductoDto> list = await _categoriaProductoService.ObtenerCategorias(datos);
                dtgCategoria.Rows.Clear();

                int cont = 0;

                foreach (CategoriaProductoDto categoria in list)
                {
                    dtgCategoria.Rows.Add(1);
                    dtgCategoria.Rows[cont].Cells[0].Value = categoria.Id.ToString();
                    dtgCategoria.Rows[cont].Cells[1].Value = categoria.Descripcion.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
        }

        private async void btnRegistracat_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar())
                {
                    CategoriaProductoRequest categoriaProducto = new CategoriaProductoRequest() { Codigo = txtCategoria.Text, Descripcion = txtCategoria.Text };
                    await _categoriaProductoService.RegistrarCategoriaProducto(categoriaProducto);
                    MessageBox.Show("Registro de provincia realizado con éxito");
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
            if (txtCategoria.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtCategoria, "Ingrese una especificación de rol");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtCategoria.Text = "";
        }

        private void txtBCategoria_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBCategoria.Text);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBCategoria.Text);
        }

        private async void dtgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgCategoria.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgCategoria.Columns.Count)
                {

                    if (dtgCategoria.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgCategoria.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgCategoria.Rows[e.RowIndex].Cells["idcategoria"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgCategoria.Rows[e.RowIndex].Cells["idcategoria"].Value);
                                txtMcategoria.Text = dtgCategoria.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                                pnlRegistrocat.Visible = false;
                                pnlModificacat.Visible = true;
                                pnllistCat.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (dtgCategoria.Columns[e.ColumnIndex].Name == "Eliminar" && dtgCategoria.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {

                            Id = Convert.ToInt32(dtgCategoria.Rows[e.RowIndex].Cells[2].Value);
                            await _categoriaProductoService.EliminarCategoriaProducto(Id);
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

        private async void btncActualizar_Click(object sender, EventArgs e)
        {
            string category = txtMcategoria.Text;
            if (!String.IsNullOrEmpty(txtMcategoria.Text))
            {

                CategoriaProductoRequest categoriaProducto = new CategoriaProductoRequest()
                { Descripcion = txtMcategoria.Text };
                await _categoriaProductoService.ActualizarCategoriaProducto(Id, categoriaProducto);
                MessageBox.Show("Datos actualizados con exito.");
                LlenarDataGrid("");
                pnlRegistrocat.Visible = false;
                pnlModificacat.Visible = false;
                pnllistCat.Visible = true;
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }

        private void ptbnewcat_Click(object sender, EventArgs e)
        {
            pnlRegistrocat.Visible = true;
            pnlModificacat.Visible = false;
            pnllistCat.Visible = false;
        }

        private void ptbRcat_Click(object sender, EventArgs e)
        {
            pnlRegistrocat.Visible = false;
            pnlModificacat.Visible = false;
            pnllistCat.Visible = true;
        }

        private void ptbAcat_Click(object sender, EventArgs e)
        {
            pnlRegistrocat.Visible = false;
            pnlModificacat.Visible = false;
            pnllistCat.Visible = true;
        }
    }
}
