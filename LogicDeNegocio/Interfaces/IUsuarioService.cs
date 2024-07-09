using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> RegistrarUsuario(UsuarioRequest request);
        Task<UsuarioDto> ActualizarUsuario(int id, UsuarioRequest request);
        Task EliminarUsuario(int id);
        Task<List<UsuarioDto>> ObtenerTodasUsuarios();
    }
}
