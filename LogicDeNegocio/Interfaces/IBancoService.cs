using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IBancoService
    {
        Task<BancoDto> RegistrarBanco(BancoRequest request);
        Task<BancoDto> ActualizarBanco(int id, BancoRequest request);
        Task EliminarBanco(int id);
        Task<List<BancoDto>> ObtenerTodasBancos();
    }
}
