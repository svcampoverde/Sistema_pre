//using LogicDeNegocio.personas;
using LogicDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LogicDeNegocio.producto;


namespace Presentacion.ModuloProducto
{
    public partial class FrmCategoria : Form
    {
       // Categoria cat = new Categoria();
        int Id;
        public FrmCategoria()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmCategoria_Load);
        }
        private void LlenarDataGrid(string datos)
        {
            try
            {
                //List<Categoria> list = cat.BuscarCategoria(datos);
                //dtgCategoria.Rows.Clear();

                //int cont = 0;

                //foreach (Categoria categoria in list)
                //{
                //    dtgCategoria.Rows.Add(1);
                //    dtgCategoria.Rows[cont].Cells[0].Value = categoria.Id.ToString();
                //    dtgCategoria.Rows[cont].Cells[1].Value = categoria.Descripcion.ToString();
                //    cont++;
                //}

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

        private void btnRegistracat_Click(object sender, EventArgs e)
        {
            //cat.Descripcion = txtCategoria.Text;
            try
            {
                //    if (Validar())
                //    {
                //        cat.InsertarCategoria(cat);
                //        MessageBox.Show("Registro de provincia realizado con éxito");
                //        Limpiar();
                //        LlenarDataGrid("");
                //    }

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

        private void dtgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgCategoria.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex <  dtgCategoria.Columns.Count)
                {
                    if (dtgCategoria.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgCategoria.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgCategoria.Rows[e.RowIndex].Cells["idcategoria"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgCategoria.Rows[e.RowIndex].Cells["idcategoria"].Value);
                                txtMcategoria.Text = dtgCategoria.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                                pnlRegistrorol.Visible = false;
                                pnlModificarol.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("La celda 'idroles' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex ==  dtgCategoria.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgCategoria.Rows[e.RowIndex].Cells["idcategoria"].Value);
                           // cat.EliminarCategoria(Id);
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

        private void btncActualizar_Click(object sender, EventArgs e)
        {
            string category = txtMcategoria.Text;
            if (!String.IsNullOrEmpty(txtMcategoria.Text))
            {
                //cat.Id = Id;
                //cat.Descripcion = category;

                //cat.ActualizarCategoria(cat);
                MessageBox.Show("Datos actualizados con exito.");
                LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }
    }
}
