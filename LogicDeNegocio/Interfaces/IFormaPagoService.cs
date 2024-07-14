using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IFormaPagoService
    {
        Task<FormaPagoDto> RegistrarFormaPago(FormaPagoRequest request);

        Task<FormaPagoDto> ActualizarFormaPago(int id, FormaPagoRequest request);

        Task EliminarFormaPago(int id);

        Task<List<FormaPagoDto>> ObtenerTodasFormaPagos();
        Task<List<FormaPagoDto>> ObtenerListForPage(string dato);
    }
}