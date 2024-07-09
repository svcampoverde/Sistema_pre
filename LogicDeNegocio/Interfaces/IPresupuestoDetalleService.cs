using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IPresupuestoDetalleService
    {
        Task<PresupuestoDetalleDto> RegistrarPresupuestoDetalle(PresupuestoDetalleRequest request);
        Task<PresupuestoDetalleDto> ActualizarPresupuestoDetalle(int id, PresupuestoDetalleRequest request);
        Task EliminarPresupuestoDetalle(int id);
        Task<List<PresupuestoDetalleDto>> ObtenerTodasPresupuestoDetalles();
    }
}
