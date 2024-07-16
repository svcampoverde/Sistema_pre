using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using Presentacion.btnpersonalizados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloProducto
{
    public partial class FormBuscarProducto : Form
    {
        private readonly IProductoService _productoService;
        private int _pageIndex = 1;
        private int _pageSize = 10;
        private int _totalPages = 0;
        private const int MaxButtonsToShow = 7; // Máximo de botones de página a mostrar
        private Panel pnlPaginas;
        private Panel panel1;
        private Label lblTotalPaginas;
        private Label lblPaginaActual;
        private List<Button> _botonesPagina; // Lista para almacenar los botones de página
        public ProductoDto ProductoSeleccionado { get; private set; }

        public FormBuscarProducto(IProductoService productoService)
        {
            _productoService = productoService;
            InitializeComponent();
            _botonesPagina = new List<Button>();
            dgvProductos.CellDoubleClick += DgvProductos_CellDoubleClick;
        }
        // Método para manejar el doble clic en una celda del DataGridView
        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductos.Rows.Count)
            {
                // Obtener el servicio seleccionado desde la fila seleccionada
                ProductoSeleccionado = dgvProductos.Rows[e.RowIndex].DataBoundItem as ProductoDto;

                // Verificar si se seleccionó un servicio válido
                if (ProductoSeleccionado != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }


        private async Task CargarProductosPaginados(string search = null)
        {
            try
            {
                var paginate = await _productoService.GetServicioPaginate(search, _pageIndex, _pageSize);
                _totalPages = (int)Math.Ceiling((double)paginate.TotalCount / _pageSize);

                dgvProductos.DataSource = paginate.Items;
                dgvProductos.Refresh();

                lblPaginaActual.Text = "Página Actual: " + _pageIndex.ToString();
                lblTotalPaginas.Text = "Total de páginas: " + _totalPages.ToString();

                MostrarBotonesDePagina();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarBotonesDePagina()
        {
            // Limpiar los botones de página anteriores
            pnlPaginas.Controls.Clear();
            _botonesPagina.Clear();

            int startPage = Math.Max(1, _pageIndex - MaxButtonsToShow / 2);
            int endPage = Math.Min(_totalPages, startPage + MaxButtonsToShow - 1);

            // Mostrar botones para las páginas disponibles en orden descendente
            for (int i = endPage; i >= startPage; i--)
            {
                var btnPagina = new Button();
                btnPagina.Text = i.ToString();
                btnPagina.Tag = i;
                btnPagina.Size = new System.Drawing.Size(30, 15);
                btnPagina.Click += BtnPagina_Click; // Asociar evento Click
                btnPagina.Dock = DockStyle.Left;
                pnlPaginas.Controls.Add(btnPagina);
                _botonesPagina.Insert(0, btnPagina); // Insertar al inicio de la lista
            }

            // Habilitar o deshabilitar botón de página anterior
            btnPaginaAnterior.Enabled = (_pageIndex > 1);

            // Habilitar o deshabilitar botón de página siguiente
            btnPaginaSiguiente.Enabled = (_pageIndex < _totalPages);
        }


        private async void FormBuscarServicio_Load(object sender, EventArgs e)
        {
            await CargarProductosPaginados();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string search = txtBuscar.Text.Trim();
            _pageIndex = 1;
            await CargarProductosPaginados(search);
        }

        private async void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                await CargarProductosPaginados(txtBuscar.Text.Trim());
            }
        }

        private async void btnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _totalPages)
            {
                _pageIndex++;
                await CargarProductosPaginados(txtBuscar.Text.Trim());
            }
        }

        private async void BtnPagina_Click(object sender, EventArgs e)
        {
            Button btnPagina = sender as Button;
            if (btnPagina != null)
            {
                int paginaSeleccionada = (int)btnPagina.Tag;
                _pageIndex = paginaSeleccionada;
                await CargarProductosPaginados(txtBuscar.Text.Trim());
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                ProductoSeleccionado = (ProductoDto)dgvProductos.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un servicio.");
            }
        }

        private void InitializeComponent()
        {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.pnlPaginas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 46);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(483, 250);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(218, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaAnterior.Location = new System.Drawing.Point(12, 309);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnPaginaAnterior.TabIndex = 7;
            this.btnPaginaAnterior.Text = "Anterior";
            this.btnPaginaAnterior.UseVisualStyleBackColor = true;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // btnPaginaSiguiente
            // 
            this.btnPaginaSiguiente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaSiguiente.Location = new System.Drawing.Point(299, 309);
            this.btnPaginaSiguiente.Name = "btnPaginaSiguiente";
            this.btnPaginaSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnPaginaSiguiente.TabIndex = 8;
            this.btnPaginaSiguiente.Text = "Siguiente";
            this.btnPaginaSiguiente.UseVisualStyleBackColor = true;
            this.btnPaginaSiguiente.Click += new System.EventHandler(this.btnPaginaSiguiente_Click);
            // 
            // pnlPaginas
            // 
            this.pnlPaginas.Location = new System.Drawing.Point(93, 309);
            this.pnlPaginas.Name = "pnlPaginas";
            this.pnlPaginas.Size = new System.Drawing.Size(200, 23);
            this.pnlPaginas.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPaginas);
            this.panel1.Controls.Add(this.lblPaginaActual);
            this.panel1.Location = new System.Drawing.Point(93, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 32);
            this.panel1.TabIndex = 11;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(130, 10);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(105, 15);
            this.lblTotalPaginas.TabIndex = 6;
            this.lblTotalPaginas.Text = "Total de páginas: 0";
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.Location = new System.Drawing.Point(3, 10);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(91, 15);
            this.lblPaginaActual.TabIndex = 5;
            this.lblPaginaActual.Text = "Página Actual: 0";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPaginas);
            this.Controls.Add(this.btnPaginaSiguiente);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarProducto";
            this.Text = "Buscar Servicio";
            this.Load += new System.EventHandler(this.FormBuscarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView dgvProductos;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnPaginaAnterior;
        private Button btnPaginaSiguiente;
    }
}