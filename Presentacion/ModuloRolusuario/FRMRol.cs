//using LogicDeNegocio.provincia;
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using LogicDeNegocio.personas;

namespace Presentacion.ModuloRolusuario
{
    public partial class FrmRol : Form
    {
        private readonly IRolService _olService;
        int Id;
        public FrmRol(RolService rolService)
        {
            _olService = rolService;
            InitializeComponent();
            this.Load += new EventHandler(FRMRol_Load);
        }

        private async void LlenarDataGrid(string datos)
        {
            try
            {
                List<RolDto> list = await _olService.ObtenerRols(datos);
                dtgRol.Rows.Clear();

                int cont = 0;

                foreach (RolDto roles in list)
                {
                    dtgRol.Rows.Add(1);
                    dtgRol.Rows[cont].Cells[0].Value = roles.Id.ToString();
                    dtgRol.Rows[cont].Cells[1].Value = roles.Descripcion.ToString();
                    cont++;
                }

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

        private async void btnRegistrarol_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    RolRequest r = new RolRequest() { Descripcion = txtRol.Text };
                    await _olService.RegistrarRol(r);
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

        private async void dtgRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgRol.Rows.Count &&
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
                            await _olService.EliminarRol(Id);
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

        private async void brnActualizar_Click(object sender, EventArgs e)
        {
            string nrol = txtErol.Text;
            if (!String.IsNullOrEmpty(txtErol.Text))
            {
                RolRequest r = new RolRequest() { Descripcion = txtErol.Text };
                await _olService.ActualizarRol(Id, r);
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
