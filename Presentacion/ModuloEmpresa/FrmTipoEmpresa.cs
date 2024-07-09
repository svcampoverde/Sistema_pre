///using LogicDeNegocio.personas;
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
//using LogicDeNegocio.Empresa;


namespace Presentacion.ModuloEmpresa
{
    public partial class FrmTipoEmpresa : Form
    {
        //TipoEmpresa temp= new TipoEmpresa();
        int Id;
        public FrmTipoEmpresa()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid(string dato)
        {
            try
            {
                //List<TipoEmpresa> list = temp.BuscarTipempresa(dato);
                //dtgTipEmpresa.Rows.Clear();

                //int cont = 0;

                //foreach (TipoEmpresa t in list)
                //{
                //    dtgTipEmpresa.Rows.Add(1);
                //    dtgTipEmpresa.Rows[cont].Cells[0].Value = t.Id.ToString();
                //    dtgTipEmpresa.Rows[cont].Cells[1].Value = t.Descripcion.ToString();
                //    cont++;
               // }

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

        private void brnGuardarTE_Click(object sender, EventArgs e)
        {
          //  temp.Descripcion = txtTipempresa.Text;
            try
            {
                if (Validar())
                {
                   // temp.InsertarTipEmpresa(temp);
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

        private void dtgTipEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
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
                                MessageBox.Show("La celda 'idroles' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgTipEmpresa.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgTipEmpresa.Rows[e.RowIndex].Cells["idtipo"].Value);
                            //temp.EliminarTipempresa(Id);
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

        private void btnActualizarTE_Click(object sender, EventArgs e)
        {
            string tipo = txtMtipemp.Text;
            if (!String.IsNullOrEmpty(txtMtipemp.Text))
            {
                //temp.Id = Id;
                //temp.Descripcion = tipo;

                //temp.ActualizarTipempresa(temp);
                MessageBox.Show("Datos actualizados con exito.");
                LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }

        private void txtBtipemp_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipemp.Text);
        }

        private void btnBuscartemp_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBtipemp.Text);
        }
    }
}
