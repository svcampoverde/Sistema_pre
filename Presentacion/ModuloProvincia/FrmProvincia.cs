using LogicDeNegocio;
using System;
using System.Windows.Forms;

namespace Presentacion.ModuloProvincia

{
    public partial class FrmProvincia : Form
    {
        // Provincia admp = new Provincia();
        int Id;
        public FrmProvincia()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmProvincia_Load);
        }
        private void LlenarDataGrid(string datos)
        {
            try
            {
                //List<Provincia> list = admp.BuscarProvincia(datos);
                //dtgProvincia.Rows.Clear();

                //int cont = 0;

                //foreach (Provincia provincia in list)
                //{
                //    dtgProvincia.Rows.Add(1);
                //    dtgProvincia.Rows[cont].Cells[0].Value = provincia.Idprovincia.ToString();
                //    dtgProvincia.Rows[cont].Cells[1].Value = provincia.Descripcionp.ToString();
                //    cont++;
                //}

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrarp_Click(object sender, EventArgs e)
        {
            string prov = txtProvincia.Text;
            try
            {
                if (Validar())
                {

                    //Provincia provincia = new Provincia(prov);
                    //admp.insertarProvincia(provincia);
                    //MessageBox.Show("Registro de provincia realizado con éxito");
                    //Limpiar();
                    //LlenarDataGrid("");
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
            if (txtProvincia.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtProvincia, "Ingrese nombre de provincia");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtProvincia.Text = "";
        }
        //eventos
        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");

        }

        private void txtBprovincia_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBprovincia.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBprovincia.Text);
        }

        private void dtgProvincia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgProvincia.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgProvincia.Columns.Count)
                {
                    if (dtgProvincia.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgProvincia.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda 'Idusuario' tenga un valor válido
                            if (dtgProvincia.Rows[e.RowIndex].Cells["idprovincia"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgProvincia.Rows[e.RowIndex].Cells["idprovincia"].Value);
                                txtMprovincia.Text = dtgProvincia.Rows[e.RowIndex].Cells["provincia"].Value.ToString();
                                pnlRegistropro.Visible = false;
                                pnlModificarpro.Visible = true;

                            }
                            else
                            {
                                MessageBox.Show("La celda 'Idusuario' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgProvincia.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            //Id = Convert.ToInt32(dtgProvincia.Rows[e.RowIndex].Cells["idprovincia"].Value);
                            //admp.EliminarProvincia(Id);
                            //LlenarDataGrid("");
                        }

                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string ciudad = txtMprovincia.Text;
            if (!String.IsNullOrEmpty(txtMprovincia.Text))
            {
                //admp.Idprovincia = Id;
                //admp.Descripcionp = ciudad;

                //admp.ActualizarProvincia(admp);
                //MessageBox.Show("Datos actualizados con exito.");
                //LlenarDataGrid("");
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }
    }
}
