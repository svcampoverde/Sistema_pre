using Datos.AplicationDB;
using LogicDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.ModuloRolusuario
{
    public partial class BuscarRol : MaterialSkin.Controls.MaterialForm
    {
        int Id;
        private readonly SistemapContext _sistemapContext;

        public BuscarRol(SistemapContext sistemapContext)
        {
            _sistemapContext = sistemapContext;
            InitializeComponent();
            LlenarDataGridR("");
            txtRol.TextChanged += new System.EventHandler(txtRol_TextChanged);
        }


        private void LlenarDataGridR(string datos)
        {
            try
            {
                var list = _sistemapContext.Rols.Where(e=>e.Descripcion.Contains(datos)).ToList();
                dtgRol.Rows.Clear();

                int cont = 0;

                foreach (var rol in list)
                {
                    dtgRol.Rows.Add(1);
                    dtgRol.Rows[cont].Cells[0].Value = rol.Id.ToString();
                    dtgRol.Rows[cont].Cells[1].Value = rol.Descripcion.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBrol_Click(object sender, EventArgs e)
        {
            LlenarDataGridR(txtRol.Text);
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGridR(txtRol.Text);
        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            //SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
            //SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);

            //LlenarDataGridR("");
            dtgRol.CellClick += new DataGridViewCellEventHandler(dtgRol_CellClick);
        }

        private void dtgRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgRol.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                Id = Convert.ToInt32(dtgRol.CurrentRow.Cells["Id"].Value.ToString());

                //Program.iniciar.Hide();

                FrmModificarRol frm = new FrmModificarRol();
                frm.ShowDialog();

            }
        }
    }
}