using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ICategoriaAtributoService
    {
        Task<CategoriaAtributoDto> RegistrarCategoriaAtributo(CategoriaAtributoRequest request);

        Task<CategoriaAtributoDto> ActualizarCategoriaAtributo(int id, CategoriaAtributoRequest request);

        Task EliminarCategoriaAtributo(int id);

        Task<List<CategoriaAtributoDto>> ObtenerTodasCategoriaAtributos();
    }
}