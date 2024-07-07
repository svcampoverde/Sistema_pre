namespace Datos.Models
{
    public class AtributoProducto : BaseEntity<int>
    {
        public int IdProducto { get; set; }
        public int IdAtributo { get; set; }
        public string Valor { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Atributo Atributo { get; set; }
    }
}
