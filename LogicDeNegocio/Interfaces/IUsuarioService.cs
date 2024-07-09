using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> RegistrarUsuarioAsync(UsuarioRequest userDto);

        Task<UsuarioDto> ActualizarUsuarioAsync(int id, UsuarioRequest userDto);

        Task<bool> CambiarClaveAsync(int id, string nuevaClave);
    }
}