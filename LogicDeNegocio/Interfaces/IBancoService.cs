using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IBancoService
    {
        Task<BancoDto> RegistrarBanco(BancoRequest request);

        Task<BancoDto> ActualizarBanco(int id, BancoRequest request);

        Task EliminarBanco(int id);

        Task<List<BancoDto>> ObtenerBancos();
    }
}