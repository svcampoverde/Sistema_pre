//using LogicDeNegocio.provincia;
using LogicDeNegocio;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LogicDeNegocio.personas;

namespace Presentacion.ModuloRolusuario
{
    public partial class FrmRol : Form
    {
       // Rol admr = new Rol();
        int Id;
        public FrmRol()
        {
            InitializeComponent();
            this.Load += new EventHandler(FRMRol_Load);
        }

        private void LlenarDataGrid(string datos)
        {
            try
            {
                //List<Rol> list = admr.BuscarRol(datos);
                //dtgRol.Rows.Clear();

                //int cont = 0;

                //foreach (Rol roles in list)
                //{
                //    dtgRol.Rows.Add(1);
                //    dtgRol.Rows[cont].Cells[0].Value = roles.Idrol.ToString();
                //    dtgRol.Rows[cont].Cells[1].Value = roles.RolUsuario.ToString();
                //    cont++;
                //}

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FRMRol_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");

        }

        private void btnRegistrarol_Click(object sender, EventArgs e)
        {
            string rol = txtRol.Text;
            try
            {
                if (Validar())
                {
                   // admr.InsertarRol(admr);
                    MessageBox.Show("Registro de provincia realizado con éxito");
                    Limpiar();
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
            if (txtRol.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtRol, "Ingrese una especificación de rol");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtRol.Text = "";
        }

        private void dtgRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex <dtgRol.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgRol.Columns.Count)
                {
                    if (dtgRol.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgRol.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgRol.Rows[e.RowIndex].Cells["idroles"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgRol.Rows[e.RowIndex].Cells["idroles"].Value);
                                txtErol.Text = dtgRol.Rows[e.RowIndex].Cells["rol"].Value.ToString();
                                pnlRegistrorol.Visible = false;
                                pnlModificarol.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("La celda 'idroles' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgRol.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgRol.Rows[e.RowIndex].Cells["idroles"].Value);
                            //admr.EliminarRol(Id);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBrol.Text);
        }

        private void txtBrol_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBrol.Text);
        }

        private void brnActualizar_Click(object sender, EventArgs e)
        {
            string nrol = txtErol.Text;
            if (!String.IsNullOrEmpty(txtErol.Text))
            {
                //admr.Idrol = Id;
                //admr.RolUsuario = nrol;

                //admr.ActualizarRol(admr);
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
