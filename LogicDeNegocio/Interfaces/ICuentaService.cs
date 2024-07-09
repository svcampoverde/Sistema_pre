using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ICuentaService
    {
        Task<CuentaDto> RegistrarCuenta(CuentaRequest request);

        Task<CuentaDto> ActualizarCuenta(int id, CuentaRequest request);

        Task EliminarCuenta(int id);

        Task<List<CuentaDto>> ObtenerTodasCuentas();
    }
}