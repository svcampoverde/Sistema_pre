namespace Datos.Models
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public decimal PrecioCompra { get; set; } = 0M;
        public decimal PrecioVenta { get; set; } = 0M;
        public virtual Producto Producto { get; set; }
    }
}
