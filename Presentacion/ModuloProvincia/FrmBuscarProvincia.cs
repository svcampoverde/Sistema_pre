using LogicDeNegocio.provincia;
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

namespace Presentacion.ModuloProvincia
{
    public partial class FrmBuscarProvincia : MaterialSkin.Controls.MaterialForm
    {
        AdmProvincia adm = new AdmProvincia();
        public FrmBuscarProvincia()
        {
            InitializeComponent();
            LlenarDataGrid("");
            txtProvincia.TextChanged += new EventHandler(txtProvincia_TextChanged);
        }

        private void LlenarDataGrid(string datos)
        {
            try
            {
                List<Provincia> list = adm.ConsultarProvincia(datos);
                dtgProvincia.Rows.Clear();

                int cont = 0;

                foreach (Provincia provincia in list)
                {
                    dtgProvincia.Rows.Add(1);
                    dtgProvincia.Rows[cont].Cells[0].Value = provincia.Descripcionp.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(txtProvincia.Text);
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txtProvincia.Text);
        }

        private void FrmBuscarProvincia_Load(object sender, EventArgs e)
        {
            LlenarDataGrid("");
            dtgProvincia.CellClick += dtgProvincia_CellClick;
        }

        private void dtgProvincia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic no sea en los encabezados
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgProvincia.Rows[e.RowIndex];

                // Editar
                if (dtgProvincia.Columns[e.ColumnIndex].Name == "btneditar")
                {
                    string descripcion = row.Cells["descripcion"].Value.ToString();
                   EditarProvincia(descripcion);
                }

                // Eliminar
                if (dtgProvincia.Columns[e.ColumnIndex].Name == "btneliminar")
                {
                    string descripcion = row.Cells["descripcion"].Value.ToString();
                    EliminarProvincia(descripcion);
                }
            }
        }

        private void EditarProvincia(string descripcion)
        {
            // Implementa la lógica para editar la provincia
            MessageBox.Show("Editar provincia: " + descripcion);
        }

        private void EliminarProvincia(string descripcion)
        {
            // Implementa la lógica para eliminar la provincia
            MessageBox.Show("Eliminar provincia: " + descripcion);
        }

        private void dtgProvincia_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex >= 0 && this.dtgProvincia.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dtgProvincia.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Recursos\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 1, e.CellBounds.Top + 1);
                this.dtgProvincia.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.dtgProvincia.Columns[e.ColumnIndex].Width = icoAtomico.Width;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dtgProvincia.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dtgProvincia.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Recursos\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 1);
                this.dtgProvincia.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.dtgProvincia.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }
    }
}
