using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoCuentaService
    {
        Task<TipoCuentaDto> RegistrarTipoCuenta(TipoCuentaRequest request);

        Task<TipoCuentaDto> ActualizarTipoCuenta(int id, TipoCuentaRequest request);

        Task EliminarTipoCuenta(int id);

        Task<List<TipoCuentaDto>> ObtenerTodasTipoCuentas();
    }
}