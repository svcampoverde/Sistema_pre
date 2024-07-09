using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

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
