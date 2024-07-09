using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

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
