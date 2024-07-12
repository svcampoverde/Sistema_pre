using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ICategoriaProductoService
    {
        Task<CategoriaProductoDto> RegistrarCategoriaProducto(CategoriaProductoRequest request);

        Task<CategoriaProductoDto> ActualizarCategoriaProducto(int id, CategoriaProductoRequest request);

        Task EliminarCategoriaProducto(int id);

        Task<List<CategoriaProductoDto>> ObtenerTodasCategoriaProductos();
        Task<List<CategoriaProductoDto>> ObtenerCategorias(string dato);
    }
}