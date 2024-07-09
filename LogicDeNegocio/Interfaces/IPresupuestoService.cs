using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IPresupuestoService
    {
        Task<PresupuestoDto> RegistrarPresupuesto(PresupuestoRequest request);

        Task<PresupuestoDto> ActualizarPresupuesto(int id, PresupuestoRequest request);

        Task EliminarPresupuesto(int id);

        Task<List<PresupuestoDto>> ObtenerTodasPresupuestos();
    }
}