
using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Presentacion.btnpersonalizados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.ModuloEmpresa
{
    public partial class FrmEmpresa : Form
    {
        private readonly IEmpresaService _empresaService;
        private readonly ITipoEmpresaService _tipoEmpresaService;
        int Id;
        public FrmEmpresa(IEmpresaService empresaService, ITipoEmpresaService tipoEmpresaService)
        {
            _empresaService = empresaService;
            _tipoEmpresaService = tipoEmpresaService ?? throw new ArgumentNullException(nameof(tipoEmpresaService));
            InitializeComponent();

        }
        private async void llenarCombobox(PersonComboBox combo)
        {
            try
            {
                var tipo = await _tipoEmpresaService.ObtenerTodasTipoEmpresas();
                if (tipo.Any())
                {
                    combo.DataSource = tipo;
                    combo.DisplayMember = "Descripcion";
                    combo.ValueMember = "Id";

                 }
                    
                }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private async void LlenarDataGrid(string dato)
        {
            try
            {
                pnlRegEmp.Visible = false;
                pnlMempresa.Visible = false;
                pnlListEmp.Visible = true;
                List<EmpresaDto> list = await _empresaService.ObtenerEmpresas(dato);
                dtgEmpresa.Rows.Clear();

                int cont = 0;

                foreach (EmpresaDto t in list)
                {
                    dtgEmpresa.Rows.Add(1);
                    dtgEmpresa.Rows[cont].Cells[0].Value = t.Id.ToString();
                    dtgEmpresa.Rows[cont].Cells[1].Value = t.Descripcion.ToString();
                    dtgEmpresa.Rows[cont].Cells[2].Value = t.TipoEmpresaDescripcion.ToString();
                    dtgEmpresa.Rows[cont].Cells[3].Value = t.Telefono.ToString();
                    dtgEmpresa.Rows[cont].Cells[4].Value = t.Correo.ToString();
                    dtgEmpresa.Rows[cont].Cells[5].Value = t.Direccion.ToString();

                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");
            llenarCombobox(cmbtipempresa);
            llenarCombobox(cmbMtipemp);
            pnlListEmp.Dock = DockStyle.Fill;
            //dtgEmpresa.Dock = DockStyle.Fill;
        }
        //private void buscarTipoEmpresa()
        //{
        //    DataTable dt = new DataTable();
        //    tp.BuscarTipempresa(ref dt, txtTipoemp.Text);
        //    dtg.DataSource = dt;
        //    dtgTipEmpresa.Columns[1].Visible = false;
        //    dtg.Columns[3].Visible = false;
        //    dtg.Visible = true;
        //}

        private void ptbadd_Click(object sender, EventArgs e)
        {
            pnlListEmp.Visible = false;
            pnlRegEmp.Visible = true;
            ptbadd.Visible = false;
            pnlRegEmp.Visible = true;
        }

        private async  void btnGuardarE_Click(object sender, EventArgs e)
        {
           try 
            {
                if (Validar())
                {
                    EmpresaRequest empresa = new EmpresaRequest()
                    {
                        Descripcion = txtEmpresa.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        Direccion = txtDireccion.Text,
                        IdTipoEmpresa = cmbtipempresa.SelectedIndex
                    };
                    await _empresaService.RegistrarEmpresa(empresa);
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
            if (txtEmpresa.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtEmpresa, "Ingrese nombre de empresa");
            }
            if (txtTelefono.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Ingrese un numero de telefono");
            }
            if (txtCorreo.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtCorreo, "Ingrese un correo");
            }
            if (txtDireccion.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtDireccion, "Ingrese una direccion");
            }
            if (cmbtipempresa.SelectedIndex < 0)
            {
                campo = false;
                errorProvider1.SetError(cmbtipempresa, "Selecione un item.");
            }
            return campo;
        }
        public void Limpiar()
        {
            txtEmpresa.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        private void ptbleft_Click(object sender, EventArgs e)
        {
            pnlListEmp.Visible = true;
            pnlRegEmp.Visible = false;
            // ptbadd.Visible = false;
            pnlRegEmp.Visible = false;
        }
        private void ptbleftm_Click(object sender, EventArgs e)
        {
            pnlListEmp.Visible = true;
            pnlRegEmp.Visible = false;
            // ptbadd.Visible = false;
            pnlRegEmp.Visible = false;
            pnlMempresa.Visible = false;
        }
        private async  void dtgEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgEmpresa.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgEmpresa.Columns.Count)
                {
                    if (dtgEmpresa.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgEmpresa.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgEmpresa.Rows[e.RowIndex].Cells["idempresa"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgEmpresa.Rows[e.RowIndex].Cells["idempresa"].Value);
                                txtMempresa.Text = dtgEmpresa.Rows[e.RowIndex].Cells["empresa"].Value.ToString();
                                cmbMtipemp.Texts = dtgEmpresa.Rows[e.RowIndex].Cells["tipempresa"].Value.ToString();
                                txtMtelefono.Text = dtgEmpresa.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                                txtMcorreo.Text = dtgEmpresa.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                                txtMdireccion.Text = dtgEmpresa.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                                pnlRegEmp.Visible = false;
                                pnlMempresa.Visible = true;
                                pnlListEmp.Visible = false;
                                cmbMtipemp.Click += new EventHandler(cmbMtipemp_Click_1);

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgEmpresa.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgEmpresa.Rows[e.RowIndex].Cells["idempresa"].Value);
                            await _empresaService.EliminarEmpresa(Id);
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

        private async void btnActualizarEmp_Click(object sender, EventArgs e)
        {
            string empresa = txtMempresa.Text, telef = txtMtelefono.Text, correo = txtMcorreo.Text, direccion = txtMdireccion.Text;
            int tpe = Convert.ToInt32(cmbMtipemp.SelectedValue);
            if (!String.IsNullOrEmpty(empresa))
            {
                EmpresaRequest empresaRequest = new EmpresaRequest()
                {
                    Id = Id,
                    Descripcion = empresa,
                    Telefono = telef,
                    Correo = correo,
                    Direccion = direccion,
                    IdTipoEmpresa = tpe
                };
                await _empresaService.ActualizarEmpresa(Id, empresaRequest);
                MessageBox.Show("Datos actualizados con exito.");
                LlenarDataGrid("");
                pnlListEmp.Visible = true;
                ptbleftm.Visible = false;
                pnlMempresa.Visible = false;
            }
            else
            {

                MessageBox.Show("Existe un campo vacio");
            }
        }

        private void CmbMtipemp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtBemp_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBemp.Text);
        }

        private void btnBuscaremp_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBemp.Text);
        }

        private void cmbMtipemp_Click_1(object sender, EventArgs e)
        {
            llenarCombobox(cmbMtipemp);
        }
    }
}
