using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoServicioService
    {
        Task<TipoServicioDto> RegistrarTipoServicio(TipoServicioRequest request);

        Task<TipoServicioDto> ActualizarTipoServicio(int id, TipoServicioRequest request);

        Task EliminarTipoServicio(int id);

        Task<List<TipoServicioDto>> ObtenerTodasTipoServicios();
        Task<List<TipoServicioDto>> ObtenerListServicio(string dato);
    }
}