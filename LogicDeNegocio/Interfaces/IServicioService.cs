using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LogicDeNegocio.Interfaces
{
    public interface IServicioService
    {
        Task<Paginate<ServicioDto>> GetServicioPaginate(string search = null, int pageIndex = 1, int pageSize = 10);

        Task<ServicioDto> RegistrarServicio(ServicioRequest request);

        Task<ServicioDto> ActualizarServicio(int id, ServicioRequest request);

        Task EliminarServicio(int id);
        int GetTotalServicios();
    }
}