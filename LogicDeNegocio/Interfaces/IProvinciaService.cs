using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IProvinciaService
    {
        Task<ProvinciaDto> RegistrarProvincia(ProvinciaRequest request);
        Task<ProvinciaDto> ActualizarProvincia(int id, ProvinciaRequest request);
        Task EliminarProvincia(int id);
        Task<List<ProvinciaDto>> ObtenerTodasProvincias();
    }
}
