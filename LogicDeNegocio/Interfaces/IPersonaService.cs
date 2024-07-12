using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IPersonaService
    {
        Task<PersonaDto> RegistrarPersona(PersonaRequest request);

        Task<PersonaDto> ActualizarPersona(int id, PersonaRequest request);

        Task EliminarPersona(int id);

        Task<List<PersonaDto>> ObtenerTodasPersonas();
        Task<List<PersonaDto>> BuscarPersona(string search);
    }
}