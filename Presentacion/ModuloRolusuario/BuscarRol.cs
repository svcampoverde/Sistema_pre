using LogicDeNegocio.provincia;
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
using LogicDeNegocio.personas;
using static MaterialSkin.MaterialItemCollection;

namespace Presentacion.ModuloRolusuario
{
    public partial class BuscarRol : MaterialSkin.Controls.MaterialForm
    {
        int Id;
        AdmRol adm = new AdmRol();
        
        public BuscarRol()
        {
            InitializeComponent();
            LlenarDataGridR("");
            txtRol.TextChanged += new System.EventHandler(txtRol_TextChanged);
        }

        
        private void LlenarDataGridR(string datos)
        {
            try
            {
                List<Rol> list = adm.ConsultarRol(datos);
                dtgRol.Rows.Clear();

                int cont = 0;

                foreach (Rol rol in list)
                {
                    dtgRol.Rows.Add(1);
                    dtgRol.Rows[cont].Cells[0].Value = rol.Idrol.ToString();
                    dtgRol.Rows[cont].Cells[1].Value = rol.RolUsuario.ToString();
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
                Program.iniciar.Hide();
                FrmModificarRol frm = new FrmModificarRol();
                frm.ShowDialog();

            }
        }
    }
}