using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IEventoService
    {
        Task<EventoDto> RegistrarEvento(EventoRequest request);
        Task<EventoDto> ActualizarEvento(int id, EventoRequest request);
        Task EliminarEvento(int id);
        Task<List<EventoDto>> ObtenerTodasEventos();
    }
}
