using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoProductoService
    {
        Task<TipoProductoDto> RegistrarTipoProducto(TipoProductoRequest request);

        Task<TipoProductoDto> ActualizarTipoProducto(int id, TipoProductoRequest request);

        Task EliminarTipoProducto(int id);

        Task<List<TipoProductoDto>> ObtenerTodasTipoProductos();
        Task<List<TipoProductoDto>> ObtenerTipoProducto(string dato);
    }
}