using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IRolService
    {
        Task<RolDto> RegistrarRol(RolRequest request);
        Task<RolDto> ActualizarRol(int id, RolRequest request);
        Task EliminarRol(int id);
        Task<List<RolDto>> ObtenerTodosLosRoles();
        Task<List<RolDto>> ObtenerRols(string dato);
    }
}
