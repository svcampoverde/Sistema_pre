using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Presentacion.ModuloProducto;
using Presentacion.ModuloServicio;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace Presentacion.ModuloPresupuesto
{
    public partial class FormAgregarDetalle : Form
    {
        private readonly IProductoService _productoService;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private TextBox txtTipoServicio;
        private Label label3;
        private TextBox txtNombreServicio;
        private Label label2;
        private Panel panel2;
        private TextBox txtTipoProducto;
        private Label label5;
        private TextBox txtNombreProducto;
        private Label label6;
        private TextBox txtPrecio;
        private Label label7;
        private TextBox txtCantidad;
        private Label label9;
        private TextBox txtIva;
        private Label label8;
        private RichTextBox richTextDescripcion;
        private Label label10;
        private readonly IServicioService _servicioService;

        public PresupuestoDto PresupuestoActual { get; set; } // Propiedad para mantener el presupuesto actual en el formulario de detalle
        public PresupuestoDetalleRequest DetalleRequest { get; private set; } // Request para el detalle del presupuesto

        public FormAgregarDetalle(IProductoService productoService, IServicioService servicioService)
        {
            _productoService = productoService;
            _servicioService = servicioService;

            InitializeComponent();
        }

        // Evento para buscar un producto
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var formBuscarProducto = UnityConfig.Container.Resolve<FormBuscarProducto>();
            if (formBuscarProducto.ShowDialog() == DialogResult.OK)
            {
                var producto = formBuscarProducto.ProductoSeleccionado;
                txtNombreProducto.Text = producto.Nombre;
                richTextDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                txtTipoProducto.Text = producto.TipoProducto;
                //.Text = producto.Precio;

                // Actualiza otros campos según necesites
            }
        }

        // Evento para buscar un servicio
        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            var formBuscarServicio = UnityConfig.Container.Resolve<FormBuscarServicio>();
            if (formBuscarServicio.ShowDialog() == DialogResult.OK)
            {
                var servicio = formBuscarServicio.ServicioSeleccionado;
                txtTipoServicio.Text = servicio.TipoServicio;
                txtNombreServicio.Text = servicio.Descripcion;
                // Actualiza otros campos según necesites
            }
        }

        // Evento para guardar el detalle del presupuesto
        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleRequest = new PresupuestoDetalleRequest
                {

                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el detalle del presupuesto: {ex.Message}");
            }
        }

        // Método generado automáticamente al diseñar el formulario
        private void InitializeComponent()
        {
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextDescripcion = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.panelDetalle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.panel2);
            this.panelDetalle.Controls.Add(this.label4);
            this.panelDetalle.Controls.Add(this.panel1);
            this.panelDetalle.Controls.Add(this.label1);
            this.panelDetalle.Controls.Add(this.btnBuscarProducto);
            this.panelDetalle.Controls.Add(this.btnBuscarServicio);
            this.panelDetalle.Controls.Add(this.btnGuardarDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 0);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(538, 346);
            this.panelDetalle.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richTextDescripcion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtIva);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTipoProducto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNombreProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 149);
            this.panel2.TabIndex = 11;
            // 
            // richTextDescripcion
            // 
            this.richTextDescripcion.Location = new System.Drawing.Point(102, 39);
            this.richTextDescripcion.Name = "richTextDescripcion";
            this.richTextDescripcion.Size = new System.Drawing.Size(136, 105);
            this.richTextDescripcion.TabIndex = 18;
            this.richTextDescripcion.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(323, 102);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(82, 23);
            this.txtCantidad.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(323, 72);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(82, 23);
            this.txtIva.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Iva";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(323, 39);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 23);
            this.txtPrecio.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Enabled = false;
            this.txtTipoProducto.Location = new System.Drawing.Point(323, 3);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(147, 23);
            this.txtTipoProducto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(102, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(136, 23);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTipoServicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreServicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 68);
            this.panel1.TabIndex = 7;
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Enabled = false;
            this.txtTipoServicio.Location = new System.Drawing.Point(75, 34);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(177, 23);
            this.txtTipoServicio.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(75, 6);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(342, 23);
            this.txtNombreServicio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servicio";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(152, 280);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(129, 35);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(3, 280);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(125, 35);
            this.btnBuscarServicio.TabIndex = 4;
            this.btnBuscarServicio.Text = "Buscar Servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Location = new System.Drawing.Point(426, 285);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(98, 30);
            this.btnGuardarDetalle.TabIndex = 0;
            this.btnGuardarDetalle.Text = "Guardar";
            this.btnGuardarDetalle.UseVisualStyleBackColor = true;
            this.btnGuardarDetalle.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // FormAgregarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 346);
            this.Controls.Add(this.panelDetalle);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "FormAgregarDetalle";
            this.Text = "Agregar Detalle";
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnGuardarDetalle;
        private System.ComponentModel.IContainer components = null;

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
