﻿using Presentacion.ModuloCliente;
using Presentacion.ModuloEmpleado;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloProducto;
using Presentacion.ModuloProveedor;
using System;
using System.Windows.Forms;
using Unity;

namespace Presentacion
{
    public partial class Home : Form
    {
        public FrmIPrincipal Frmdi;
        private IUnityContainer _container;
        public Home(IUnityContainer container, FrmIPrincipal mdip)
        {
            InitializeComponent();
            this.Load += new EventHandler(Home_Load);
            this.Frmdi = mdip;
            this._container = container;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void ptbempresa_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmEmpresa>();
        }
        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void ptbCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmCategoria>();
        }

        private void ptbproveedor_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmRegistroProveedor>();
        }

        private void ptbICliente_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmRegistrarCliente>();
        }

        private void ptempleado_Click(object sender, EventArgs e)
        {
            this.Close();

            Frmdi.OpenChildForm<FrmEmpleado>();
        }

        private void ptbIproducto_Click(object sender, EventArgs e)
        {

        }

        private void ptbIpresupuesto_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmTipoEmpresa>();
        }

        private void ptbCategoria_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Frmdi.OpenChildForm<FrmCategoria>();
        }
    }
}
