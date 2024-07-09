using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IServicioService
    {
        Task<ServicioDto> RegistrarServicio(ServicioRequest request);
        Task<ServicioDto> ActualizarServicio(int id, ServicioRequest request);
        Task EliminarServicio(int id);
        Task<List<ServicioDto>> ObtenerTodasServicios();
    }
}
