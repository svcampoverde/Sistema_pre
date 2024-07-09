using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IInventarioService
    {
        Task<InventarioDto> RegistrarInventario(InventarioRequest request);
        Task<InventarioDto> ActualizarInventario(int id, InventarioRequest request);
        Task EliminarInventario(int id);
        Task<List<InventarioDto>> ObtenerTodasInventarios();
    }
}
