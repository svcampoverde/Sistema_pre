using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IAtributoService
    {
        Task<AtributoDto> RegistrarAtributo(AtributoRequest request);

        Task<AtributoDto> ActualizarAtributo(int id, AtributoRequest request);

        Task EliminarAtributo(int id);

        Task<List<AtributoDto>> ObtenerTodasAtributos();
    }
}