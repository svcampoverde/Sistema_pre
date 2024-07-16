using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.Extensions.Logging;
using Presentacion.ModuloProducto;
using Presentacion.ModuloServicio;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Presentacion.ModuloPresupuesto
{
    public partial class FormPresupuesto : Form
    {
        private readonly IPresupuestoService _presupuestoService;
        private readonly IPresupuestoDetalleService _presupuestoDetalleService;
        private readonly IProductoService _productoService;
        private readonly IServicioService _servicioService;
        private readonly ILogger<FormPresupuesto> _logger;
        private Label label1;
        private PresupuestoDto presupuestoActual; // Variable para mantener el estado del presupuesto actual

        public FormPresupuesto(
            IPresupuestoService presupuestoService,
            IPresupuestoDetalleService presupuestoDetalleService,
            IProductoService productoService,
            IServicioService servicioService,
            ILogger<FormPresupuesto> logger)
        {
            _presupuestoService = presupuestoService;
            _presupuestoDetalleService = presupuestoDetalleService;
            _productoService = productoService;
            _servicioService = servicioService;
            _logger = logger;

            InitializeComponent();
        }

        // Evento para buscar un producto
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var formBuscarProducto = UnityConfig.Container.Resolve<FormBuscarProducto>();
            if (formBuscarProducto.ShowDialog() == DialogResult.OK)
            {
                var producto = formBuscarProducto.ProductoSeleccionado;
                lblCodigo.Text = producto.Descripcion.ToString(); // Actualiza los campos en el formulario principal
                // Asigna el producto seleccionado al presupuesto actual si es necesario
            }
        }

        // Evento para buscar un servicio
        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            var formBuscarServicio = UnityConfig.Container.Resolve<FormBuscarServicio>();
            if (formBuscarServicio.ShowDialog() == DialogResult.OK)
            {
                var servicio = formBuscarServicio.ServicioSeleccionado;
                lblVersion.Text = servicio.Descripcion.ToString(); // Actualiza los campos en el formulario principal
                // Asigna el servicio seleccionado al presupuesto actual si es necesario
            }
        }

        // Evento para guardar la cabecera del presupuesto
        private async void btnGuardarCabecera_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new PresupuestoRequest
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Version = float.Parse(txtVersion.Text),
                    Descripcion = txtDescripcion.Text,
                    FechaEvento = dtpFechaEvento.Value,
                    FechaCotizacion = dtpFechaCotizacion.Value,
                    Descuento = float.Parse(txtDescuento.Text),
                    Iva = float.Parse(txtIva.Text),
                    Total = float.Parse(txtTotal.Text),
                    // Asigna los demás campos de la cabecera del presupuesto según tus necesidades
                };

                presupuestoActual = await _presupuestoService.RegistrarPresupuesto(request);
                MessageBox.Show("Presupuesto registrado con éxito.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar el presupuesto.");
                MessageBox.Show("Error al guardar el presupuesto.");
            }
        }

        // Evento para agregar un detalle al presupuesto
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            var formAgregarDetalle = new FormAgregarDetalle(_productoService, _servicioService);
            if (presupuestoActual != null)
                formAgregarDetalle.PresupuestoActual = presupuestoActual; // Pasa el presupuesto actual al formulario de detalle

            if (formAgregarDetalle.ShowDialog() == DialogResult.OK)
            {
                // Obtén el detalle del formulario de detalle
                var detalleRequest = formAgregarDetalle.DetalleRequest;
                detalleRequest.IdPresupuesto = presupuestoActual.Id; // Asigna el ID del presupuesto actual al detalle

                // Llama al servicio para registrar el detalle del presupuesto
                try
                {
                    var resultado = _presupuestoDetalleService.RegistrarPresupuestoDetalle(detalleRequest);
                    MessageBox.Show("Detalle del presupuesto agregado con éxito.");
                    // Actualiza el DataGridView o la lista de detalles en el formulario principal
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al agregar el detalle del presupuesto.");
                    MessageBox.Show("Error al agregar el detalle del presupuesto.");
                }
            }
        }

        // Método generado automáticamente al diseñar el formulario
        private void InitializeComponent()
        {
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCotizacion = new System.Windows.Forms.DateTimePicker();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGuardarCabecera = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.lblFechaCotizacion = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.txtCodigo);
            this.panelCabecera.Controls.Add(this.txtVersion);
            this.panelCabecera.Controls.Add(this.txtDescripcion);
            this.panelCabecera.Controls.Add(this.dtpFechaEvento);
            this.panelCabecera.Controls.Add(this.dtpFechaCotizacion);
            this.panelCabecera.Controls.Add(this.txtDescuento);
            this.panelCabecera.Controls.Add(this.txtIva);
            this.panelCabecera.Controls.Add(this.txtTotal);
            this.panelCabecera.Controls.Add(this.btnBuscarProducto);
            this.panelCabecera.Controls.Add(this.btnBuscarServicio);
            this.panelCabecera.Controls.Add(this.btnGuardarCabecera);
            this.panelCabecera.Controls.Add(this.btnAgregarDetalle);
            this.panelCabecera.Controls.Add(this.lblCodigo);
            this.panelCabecera.Controls.Add(this.lblVersion);
            this.panelCabecera.Controls.Add(this.lblDescripcion);
            this.panelCabecera.Controls.Add(this.lblFechaEvento);
            this.panelCabecera.Controls.Add(this.lblFechaCotizacion);
            this.panelCabecera.Controls.Add(this.lblDescuento);
            this.panelCabecera.Controls.Add(this.lblIva);
            this.panelCabecera.Controls.Add(this.lblTotal);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(800, 450);
            this.panelCabecera.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(114, 45);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 71);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Location = new System.Drawing.Point(114, 97);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEvento.TabIndex = 4;
            // 
            // dtpFechaCotizacion
            // 
            this.dtpFechaCotizacion.Location = new System.Drawing.Point(114, 123);
            this.dtpFechaCotizacion.Name = "dtpFechaCotizacion";
            this.dtpFechaCotizacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCotizacion.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(114, 149);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(114, 175);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(114, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(320, 17);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(320, 43);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarServicio.TabIndex = 10;
            this.btnBuscarServicio.Text = "Buscar Servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // btnGuardarCabecera
            // 
            this.btnGuardarCabecera.Location = new System.Drawing.Point(320, 201);
            this.btnGuardarCabecera.Name = "btnGuardarCabecera";
            this.btnGuardarCabecera.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCabecera.TabIndex = 11;
            this.btnGuardarCabecera.Text = "Guardar";
            this.btnGuardarCabecera.UseVisualStyleBackColor = true;
            this.btnGuardarCabecera.Click += new System.EventHandler(this.btnGuardarCabecera_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(320, 230);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar Detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Versión:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 74);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Location = new System.Drawing.Point(12, 103);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(87, 13);
            this.lblFechaEvento.TabIndex = 16;
            this.lblFechaEvento.Text = "Fecha del Evento:";
            // 
            // lblFechaCotizacion
            // 
            this.lblFechaCotizacion.AutoSize = true;
            this.lblFechaCotizacion.Location = new System.Drawing.Point(12, 129);
            this.lblFechaCotizacion.Name = "lblFechaCotizacion";
            this.lblFechaCotizacion.Size = new System.Drawing.Size(99, 13);
            this.lblFechaCotizacion.TabIndex = 17;
            this.lblFechaCotizacion.Text = "Fecha de Cotización:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 152);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 18;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(12, 178);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 19;
            this.lblIva.Text = "IVA:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // FormPresupuesto
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCabecera);
            this.Name = "FormPresupuesto";
            this.Text = "Registrar Presupuesto";
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaCotizacion;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnGuardarCabecera;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.Label lblFechaCotizacion;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
    }
}
