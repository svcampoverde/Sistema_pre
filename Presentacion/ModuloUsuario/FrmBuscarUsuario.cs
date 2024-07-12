using Datos.Models;

using LogicDeNegocio;
using LogicDeNegocio.Interfaces;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Windows.Forms;

using Unity;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmBuscarUsuario : Form
    {
        private FrmIPrincipal Frmdi;
        private IUnityContainer _container;
        private readonly IUsuarioService _service;
        private readonly IPersonaService _personaService;
        // private readonly IUsuarioService _usuarioService;
        private Usuario u = new Usuario();
        private int Id;

        public FrmBuscarUsuario(IUnityContainer container, FrmIPrincipal mdip, IUsuarioService service, IPersonaService personaService)//), IUsuarioService usuarioService)
        {
            InitializeComponent();
            this.Load += new EventHandler(BuscarUsuario_Load);
            this.Frmdi = mdip;
            this._container = container;
            //this._usuarioService = usuarioService;
            this.dtgUsuario.CellClick += new DataGridViewCellEventHandler(this.dtgUsuario_CellClick);
            _service = service;
            _personaService = personaService;
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            llenarDatagrid("");
            txtBuscar.TextChanged += new System.EventHandler(txtBuscar_TextChanged);
            dtgUsuario.CellClick += new DataGridViewCellEventHandler(dtgUsuario_CellClick);
        }
        private async void llenarDatagrid(string datos)
        {
            try
            {
                dtgUsuario.DataSource=await _personaService.BuscarPersona(datos);


            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarDatagrid(txtBuscar.Text);
        }
        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtgUsuario.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < dtgUsuario.Columns.Count)
                {
                    if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnEditar" &&
                        dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                        dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value != null)
                    {
                        int id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value);
                        this.Close();

                        //Frmdi.OpenChildForm<FrmModificarUsuario>(frm => frm.SetIdUsuario(id));
                        this.Close();
                        Frmdi.OpenChildForm<FrmModificarUsuario>(frm => frm.SetIdUsuario(id));
                    }
                    else
                    {
                        MessageBox.Show("La celda 'Idusuario' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDatagrid(txtBuscar.Text);
        }
    }
}
