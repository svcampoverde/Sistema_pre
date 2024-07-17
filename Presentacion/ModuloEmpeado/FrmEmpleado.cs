using LogicDeNegocio;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloEmpleado
{
    public partial class FrmEmpleado : Form
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly IPersonaService _personaService;
        private readonly IEmpresaService _empresaService;
        private readonly ICiudadService _ciudadService;
        int Id;
        public FrmEmpleado(IEmpleadoService empleadoService, IPersonaService persona, ICiudadService ciudad, IEmpresaService empresa)
        {
            _empleadoService = empleadoService;
            _personaService = persona;
            _empresaService = empresa ?? throw new ArgumentNullException(nameof(empresa));
            _ciudadService = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            InitializeComponent();
        }
        private async Task LlenarComboBoxCiudades()
        {
            try
            {
                var ciudades = await _ciudadService.obtenerCiudades();
                if (ciudades.Any())
                {
                    cbmciudjob.DataSource = ciudades;
                    cbmciudjob.DisplayMember = "Nombre";
                    cbmciudjob.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboBoxEmpresas()
        {
            try
            {
                var empresa = await _empresaService.ObtenerTodasEmpresas();
                if (empresa.Any())
                {
                    cmbempjob.DataSource = empresa;
                    cmbempjob.DisplayMember = "Descripcion";
                    cmbempjob.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LlenarDataGrid(string cedula)
        {
            try
            {
                pnlRegjob.Visible = false;
                pnlMjob.Visible = false;
                pnlListJob.Visible = true;
                List<EmpleadoDto> list = await _empleadoService.ObtenerEmpleados(cedula);
                dtgEmpleado.Rows.Clear();

                int cont = 0;

                foreach (EmpleadoDto empleado in list)
                {
                    dtgEmpleado.Rows.Add(1);
                    dtgEmpleado.Rows[cont].Cells[0].Value = empleado.Id.ToString();
                    dtgEmpleado.Rows[cont].Cells[1].Value = empleado.Cedula.ToString();
                    dtgEmpleado.Rows[cont].Cells[2].Value = empleado.Nombre.ToString();
                    dtgEmpleado.Rows[cont].Cells[3].Value = empleado.Apellido.ToString();
                    dtgEmpleado.Rows[cont].Cells[4].Value = empleado.Genero.ToString();
                    dtgEmpleado.Rows[cont].Cells[5].Value = empleado.Telefono.ToString();
                    dtgEmpleado.Rows[cont].Cells[6].Value = empleado.Celular.ToString();
                    dtgEmpleado.Rows[cont].Cells[7].Value = empleado.Empresa.ToString();
                    dtgEmpleado.Rows[cont].Cells[8].Value = empleado.Sueldo.ToString();
                    dtgEmpleado.Rows[cont].Cells[9].Value = empleado.Correo.ToString();
                    dtgEmpleado.Rows[cont].Cells[10].Value = empleado.Direccion.ToString();
                    dtgEmpleado.Rows[cont].Cells[11].Value = empleado.CiudadDescripcion.ToString();
                    dtgEmpleado.Rows[cont].Cells[12].Value = empleado.FechaContrato.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnGuardarjob_Click(object sender, System.EventArgs e)
        {
            //string fecha = Convert.ToDateTime(txtdatecontr.Text);
            PersonaRequest request = new PersonaRequest()
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Genero = cmbgeneroj.Texts,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Correo = txtCorreoj.Text,
                Direccion = txtCorreoj.Text,
                IdCiudad = cbmciudjob.SelectedIndex,

            };
            PersonaDto idperson = await _personaService.RegistrarPersona(request);

            
            EmpleadoRequest empleado = new EmpleadoRequest()
            {
                IdPersona = idperson.Id,
                IdCiudad = cbmciudjob.SelectedIndex,

                FechaContrato = Convert.ToDateTime(txtdatecontr.Text),
                Sueldo = Convert.ToDecimal(txtSalario.Text),
                Empresa = cmbempjob.Texts,
            };
            await _empleadoService.RegistrarEmpleado(empleado);
            LlenarDataGrid("");
            MessageBox.Show("Empleado registrado con exitó.");


        }

        private async void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LlenarDataGrid("");

            await Task.WhenAll(LlenarComboBoxEmpresas(), LlenarComboBoxCiudades());
        }

        private async void dtgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex < dtgEmpleado.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgEmpleado.Columns.Count)
                {

                    if (dtgEmpleado.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgEmpleado.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda tenga un valor válido
                            if (dtgEmpleado.Rows[e.RowIndex].Cells["idempleado"].Value != null)
                            {
                                Id = Convert.ToInt32(dtgEmpleado.Rows[e.RowIndex].Cells["idempleado"].Value);
                                txtMCedula.Text = dtgEmpleado.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
                                txtMnombre.Text = dtgEmpleado.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                                txtMApellidoem.Text = dtgEmpleado.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                                cmbMgeneroj.Texts = dtgEmpleado.Rows[e.RowIndex].Cells["genero"].Value.ToString();
                                txtMTelefono.Text = dtgEmpleado.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                                txtMCelular.Text = dtgEmpleado.Rows[e.RowIndex].Cells["celular"].Value.ToString();
                                cmbMempj.Texts = dtgEmpleado.Rows[e.RowIndex].Cells["empresa"].Value.ToString();
                                txtMsalario.Text = dtgEmpleado.Rows[e.RowIndex].Cells["sueldo"].Value.ToString();
                                txtMCorreo.Text = dtgEmpleado.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                                txtMdireccion.Text = dtgEmpleado.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                                cmbMCiudadjob.Texts = dtgEmpleado.Rows[e.RowIndex].Cells["ciudad"].Value.ToString();
                                txtMfechacontrat.Text = dtgEmpleado.Rows[e.RowIndex].Cells["fechacontrato"].Value.ToString();
                                pnlRegjob.Visible = false;
                                pnlMjob.Visible = true;
                                pnlListJob.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("La celda no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (e.ColumnIndex == dtgEmpleado.Columns["btnEliminar"].Index)
                    {
                        DialogResult result = MessageBox.Show("Se eliminara el registro de forma permanete. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Id = Convert.ToInt32(dtgEmpleado.Rows[e.RowIndex].Cells["idempleado"].Value);

                            EmpleadoDto dto = await _empleadoService.ObtenerEmpleadoPorId(Id);
                            
                            await _empleadoService.EliminarEmpleado(dto.Id);
                            await _personaService.EliminarPersona(dto.IdPersona);
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

        private async void btnModijob_Click(object sender, EventArgs e)
        {
            try 
            {
                //if(!String.IsNullOrEmpty(txtApellido.Text))
                //{
                    EmpleadoDto empleadoid = await _empleadoService.ObtenerEmpleadoPorId(Id);
                    PersonaRequest request = new PersonaRequest()
                    {
                        Cedula = txtMCedula.Text,
                        Nombre = txtMnombre.Text,
                        Apellido = txtMApellidoem.Text,
                        Telefono = txtMTelefono.Text,
                        Celular=txtMCelular.Text,
                        Correo=txtMCorreo.Text,
                        Direccion=txtMdireccion.Text,
                        Genero=cmbMgeneroj.Text,
                    //    IdCiudad=cmbMCiudadjob.SelectedIndex

                    };
                    await _personaService.ActualizarPersona(empleadoid.IdPersona, request);

                    EmpleadoRequest empleado = new EmpleadoRequest
                    {
                        Empresa=cmbMempj.Texts,
                     //   IdCiudad = cmbMCiudadjob.SelectedIndex,
                        FechaContrato = Convert.ToDateTime(txtMfechacontrat.Text),
                        Sueldo = Convert.ToDecimal(txtMsalario.Text),
                        
                    };
                    await _empleadoService.ActualizarEmpleado(empleadoid.Id, empleado);
                    

                    MessageBox.Show("Datos actualizados con exito.");
                    pnlMjob.Visible = false;
                    pnlListJob.Visible = true;
                    LlenarDataGrid("");
              //  }
            }catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbaddjob_Click(object sender, EventArgs e)
        {
            pnlRegjob.Visible = true;
            pnlListJob.Visible=false;
        }

        private void txtBjob_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBjob.Text);
        }

        private void btnBuscarjob_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtBjob.Text);
        }

        private void ptblefRtjob_Click(object sender, EventArgs e)
        {
            pnlListJob.Visible=true;
            pnlRegjob.Visible=false;
        }

        private void ptbmjob_Click(object sender, EventArgs e)
        {
            pnlListJob.Visible = true;
            pnlMjob.Visible=false;
        }
    }
}
