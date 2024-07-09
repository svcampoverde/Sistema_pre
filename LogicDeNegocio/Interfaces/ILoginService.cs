using LogicDeNegocio.Dtos;

using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ILoginService
    {
        Task<UsuarioDto> LoginAsync(string nombreUsuario, string clave);
    }
}