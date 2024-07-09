using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IAtributoProductoService
    {
        Task<AtributoProductoDto> RegistrarAtributoProducto(AtributoProductoRequest request);
        Task<AtributoProductoDto> ActualizarAtributoProducto(int id, AtributoProductoRequest request);
        Task EliminarAtributoProducto(int id);
        Task<List<AtributoProductoDto>> ObtenerTodasAtributoProductos();
    }
}
