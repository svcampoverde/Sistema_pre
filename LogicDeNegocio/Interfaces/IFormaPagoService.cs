using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IFormaPagoService
    {
        Task<FormaPagoDto> RegistrarFormaPago(FormaPagoRequest request);
        Task<FormaPagoDto> ActualizarFormaPago(int id, FormaPagoRequest request);
        Task EliminarFormaPago(int id);
        Task<List<FormaPagoDto>> ObtenerTodasFormaPagos();
    }
}
