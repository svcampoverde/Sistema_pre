using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
namespace LogicDeNegocio.Interfaces
{
    public interface IUserService
    {
         Task<UserDto> RegistrarUsuarioAsync(UserDto userDto);
    }
}
