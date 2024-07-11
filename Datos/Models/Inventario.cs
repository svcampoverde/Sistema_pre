namespace Datos.Models
{
    public partial class Inventario : BaseEntity<int>
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public decimal PrecioCompra { get; set; } = 0M;
        public decimal PrecioVenta { get; set; } = 0M;
        public virtual Producto Producto { get; set; }
    }
}
