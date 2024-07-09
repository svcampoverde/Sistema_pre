using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface ICategoriaProductoService
    {
        Task<CategoriaProductoDto> RegistrarCategoriaProducto(CategoriaProductoRequest request);
        Task<CategoriaProductoDto> ActualizarCategoriaProducto(int id, CategoriaProductoRequest request);
        Task EliminarCategoriaProducto(int id);
        Task<List<CategoriaProductoDto>> ObtenerTodasCategoriaProductos();
    }
}
