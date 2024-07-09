using Datos.Models;

using LogicDeNegocio;
//using LogicDeNegocio.personas;
using MaterialSkin;
using Microsoft.VisualBasic.ApplicationServices;
using Presentacion.ModuloRolusuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace Presentacion.ModuloUsuario
{
    public partial class BuscarUsuario : Form//MaterialSkin.Controls.MaterialForm
    {
        FrmIPrincipal Frmdi;
        Usuario u = new Usuario();
        int Id;
        public BuscarUsuario(FrmIPrincipal mdip)
        {
            InitializeComponent();
            this.Load += new EventHandler(BuscarUsuario_Load);
            this.Frmdi = mdip;
            this.dtgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellClick);

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
        private void llenarDatagrid(string datos)
        {
            try
            {
                //List<Usuario> list = u.BuscarUs(datos);
                //dtgUsuario.Rows.Clear();

                //int cont = 0;

                //foreach (Usuario us in list)
                //{
                //    dtgUsuario.Rows.Add(1);
                //    dtgUsuario.Rows[cont].Cells[0].Value = us.Id.ToString();
                //    dtgUsuario.Rows[cont].Cells[1].Value = us.Cedula.ToString();
                //    dtgUsuario.Rows[cont].Cells[2].Value = us.Nombre.ToString();
                //    dtgUsuario.Rows[cont].Cells[3].Value = us.Apellido.ToString();
                //    dtgUsuario.Rows[cont].Cells[4].Value = us.Telefono.ToString();
                //    dtgUsuario.Rows[cont].Cells[5].Value = us.Celular.ToString();
                //    dtgUsuario.Rows[cont].Cells[6].Value = us.Ciudad.Descripcion.ToString();
                //    dtgUsuario.Rows[cont].Cells[7].Value = us.User.ToString();
                //    cont++;
                //}

            }
            catch(ExceptionSistema ex)
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
                // Verificar que el índice de la columna y la fila estén dentro del rango
                if (e.RowIndex >= 0 && e.RowIndex<dtgUsuario.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex<dtgUsuario.Columns.Count)
                {
                    if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        // Verificar si la columna es de tipo DataGridViewImageColumn
                        if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                        {
                            // Verificar que la celda 'Idusuario' tenga un valor válido
                            if (dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value != null)
                            {
                                int id = Convert.ToInt32(dtgUsuario.Rows[e.RowIndex].Cells["Idusuario"].Value);

                                this.Close();
                Frmdi.OpenChildForm(new btnActualizar(id));
                            }
                            else
                            {
                                MessageBox.Show("La celda 'Idusuario' no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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

    }
}
