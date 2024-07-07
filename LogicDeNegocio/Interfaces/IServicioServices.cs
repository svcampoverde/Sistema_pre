using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IServicioServices
    {
        Task<Paginate<ServicioDto>> GetServicioPaginate(string search = null,int pageIndex=1, int pageSize=10);
        Task<ServicioDto> RegistrarServicio(ServicioRequest request);
        Task<ServicioDto> ActualizarServicio(int id, ServicioRequest request);
        Task EliminarServicio(int id);
       int  GetTotalServicios();


    }
}
