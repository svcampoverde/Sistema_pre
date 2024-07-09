using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoServicioService
    {
        Task<TipoServicioDto> RegistrarTipoServicio(TipoServicioRequest request);
        Task<TipoServicioDto> ActualizarTipoServicio(int id, TipoServicioRequest request);
        Task EliminarTipoServicio(int id);
        Task<List<TipoServicioDto>> ObtenerTodasTipoServicios();
    }
}
