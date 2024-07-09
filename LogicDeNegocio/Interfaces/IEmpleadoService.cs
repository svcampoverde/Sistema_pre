using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IEmpleadoService
    {
        Task<EmpleadoDto> RegistrarEmpleado(EmpleadoRequest request);

        Task<EmpleadoDto> ActualizarEmpleado(int id, EmpleadoRequest request);

        Task EliminarEmpleado(int id);

        Task<List<EmpleadoDto>> ObtenerTodasEmpleados();
    }
}