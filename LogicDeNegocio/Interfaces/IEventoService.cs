using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IEventoService
    {
        Task<EventoDto> RegistrarEvento(EventoRequest request);

        Task<EventoDto> ActualizarEvento(int id, EventoRequest request);

        Task EliminarEvento(int id);

        Task<List<EventoDto>> ObtenerTodasEventos();
        Task<List<EventoDto>> ObtenerListEvent(string dato);
    }
}