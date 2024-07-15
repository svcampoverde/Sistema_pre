using LogicDeNegocio.Interfaces;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using DevComponents.DotNetBar.Validator;
using LogicDeNegocio;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Dtos;

namespace Presentacion.ModuloProducto
{
    public partial class FrmInventario : Form
    {
        private readonly ITipoProductoService _tipoProducto;
        private readonly IProductoService _productoService;
        private readonly ICategoriaProductoService _categoriaProductoService;
        private readonly ICategoriaAtributoService _categoriaAtributoService;
        private readonly IAtributoProductoService _atributoProductoService;
        private readonly IInventarioService _inventarioService;
        public FrmInventario(ITipoProductoService tipo, IProductoService producto, ICategoriaAtributoService atributoService,
            ICategoriaProductoService productoService, IInventarioService inventario, IAtributoProductoService atributoProductoService)
        {
            _tipoProducto = tipo;
            _productoService = producto;
            _categoriaProductoService = productoService;
            _categoriaAtributoService = atributoService;
            _inventarioService = inventario;
            _atributoProductoService = atributoProductoService;
            InitializeComponent();
            
        }
        private async Task LlenarComboTipoProducto()
        {
            try
            {
                var tipos = await _tipoProducto.ObtenerTodasTipoProductos();
                if (tipos.Any())
                {
                    cmbtipoProducto.DataSource = tipos;
                    cmbtipoProducto.DisplayMember = "Descripcion";
                    cmbtipoProducto.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LlenarComboCategoria()
        {
            try
            {
                var categorias = await _categoriaProductoService.ObtenerTodasCategoriaProductos();
                if (categorias.Any())
                {
                    cmbCatproducto.DataSource = categorias;
                    cmbCatproducto.DisplayMember = "Descripcion";
                    cmbCatproducto.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmInventario_Load(object sender, System.EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            await Task.WhenAll(LlenarComboTipoProducto(), LlenarComboCategoria());
            // LlenarDataGrid("");
        }

        private async void btnGuardarprove_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (Validar())
                {
                    ProductoRequest pro = new ProductoRequest()
                    {
                        Nombre = txtProducto.Text,
                        Descripcion = txtDescripcionproducto.Text,
                        Precio = Convert.ToDecimal(txtpreciovent.Text),
                        IdCategoriaProducto = cmbCatproducto.SelectedIndex,
                        IdTipoProducto = cmbtipoProducto.SelectedIndex
                    };

                    ProductoDto dto = await _productoService.RegistrarProducto(pro);
                    if (dto != null && dto.Id > 0)
                    {
                        int productoId = dto.Id;
                        InventarioRequest inv = new InventarioRequest()
                        {
                            Digitador = txtUsmodificado.Text,
                            TipoMaterial = cmbTipomaterial.Text,
                            Ubicacion = txtUbicacion.Text,
                            Cantidad = Convert.ToInt32(txtCantidad.Text),
                            EstadoProducto = cmbEstproducto.Text,
                            PrecioCompra = Convert.ToDecimal(txtprecosto.Text),
                            PrecioVenta = Convert.ToDecimal(txtpreciovent.Text),
                            ProductoId = productoId
                        };

                        await _inventarioService.RegistrarInventario(inv);

                        // Crear el objeto AtributoProductoRequest
                        AtributoProductoRequest atributoRequest = new AtributoProductoRequest()
                        {
                            IdProducto = productoId,
                            Valor = txtEspecificacion.Text
                        };

                        await _atributoProductoService.RegistrarAtributoProducto(atributoRequest);
                        MessageBox.Show("Producto y atributos registrados con éxito.");
                    }
                    else
                    {
                        throw new ExceptionSistema("Error al registrar el producto. ID no válido.");
                    }
                    ////ProductoRequest pro = new ProductoRequest()
                    ////{ Nombre=txtProducto.Text, Descripcion=txtDescripcionproducto.Text, Precio=Convert.ToDecimal(txtpreciovent.Text), IdCategoriaProducto=cmbCatproducto.SelectedIndex,
                    ////  IdTipoProducto=cmbtipoProducto.SelectedIndex
                    ////};  
                    ////// Registrar el producto y obtener el ID
                    ////    //int productoId = await _productoService.RegistrarProducto(pro);
                    ////ProductoDto dto = await _productoService.RegistrarProducto(pro);
                    ////if (dto != null && dto.Id > 0)
                    ////{

                    ////    int productoId = dto.Id;
                    ////    MessageBox.Show("Producto registrado con éxito." + productoId);
                    ////    InventarioRequest inv = new InventarioRequest()
                    ////    {

                    ////        Digitador = txtUsmodificado.Text,
                    ////        TipoMaterial = cmbTipomaterial.Text,
                    ////        Ubicacion=txtUbicacion.Text,
                    ////        Cantidad = Convert.ToInt32(txtCantidad.Text),
                    ////        EstadoProducto = cmbEstproducto.Text,
                    ////        PrecioCompra = Convert.ToDecimal(txtprecosto.Text),
                    ////        PrecioVenta = Convert.ToDecimal(txtpreciovent.Text),
                    ////        ProductoId = productoId
                    ////    };

                    ////    await _inventarioService.RegistrarInventario(inv);

                    ////    AtributoProductoRequest atributoRequest = new AtributoProductoRequest()
                    ////    {
                    ////        IdProducto = productoId,
                    ////        Valor = txtEspecificacion.Text
                    ////    };
                    ////    DialogResult dialogResult = MessageBox.Show("el valor es: "+productoId);

                    ////    await _atributoProductoService.RegistrarAtributoProducto(atributoRequest);
                    ////    MessageBox.Show("Producto registrado con éxito....");
                    ////}
                    ////else
                    ////{
                    ////    throw new ExceptionSistema("Error al registrar el producto. ID no válido.");
                    ////}
                    //MessageBox.Show("exito");
                    //int productoId = dto.Id;
                    //InventarioRequest inv = new InventarioRequest()
                    //{
                    //    Digitador = txtUsmodificado.Text,
                    //    TipoMaterial = cmbTipomaterial.Texts,
                    //    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    //    EstadoProducto = cmbEstproducto.Texts,
                    //    PrecioCompra = Convert.ToDecimal(txtprecosto.Text),
                    //    PrecioVenta = Convert.ToDecimal(txtpreciovent.Text),
                    //    ProductoId = productoId
                    //};
                    //await _inventarioService.RegistrarInventario(inv);
                    //AtributoProductoRequest atributoRequest = new AtributoProductoRequest() { IdProducto = productoId, Valor = txtEspecificacion.Text };
                    //await _atributoProductoService.RegistrarAtributoProducto(atributoRequest);

                }
            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool Validar()
        {
            bool campo = true;
            if (txtProducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtProducto, "Ingrese un nombre de producto");
            }
            if (txtDescripcionproducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtDescripcionproducto, "Ingrese una descripción de producto");
            }
            if (txtProducto.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtProducto, "Ingrese un tipo de producto");
            }
            return campo;
        }

        private void txtDescripcionproducto_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("edita");
        }
    }
}
