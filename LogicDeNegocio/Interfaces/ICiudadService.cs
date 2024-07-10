using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface ICiudadService
    {
        Task<CiudadDto> RegistrarCiudad(CiudadRequest request);
        Task<CiudadDto> ActualizarCiudad(int id, CiudadRequest request);
        Task EliminarCiudad(int id);
        Task<List<CiudadDto>> obtenerCiudades();
    }
}
