using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;
namespace LogicDeNegocio.Interfaces
{
    public interface IUserService
    {
        Task<UsuarioDto> RegistrarUsuarioAsync(UsuarioRequest userDto);
        Task<UsuarioDto> ActualizarUsuarioAsync(int id, UsuarioRequest userDto);
        Task<bool> CambiarClaveAsync(int id, string nuevaClave);
    }
}
