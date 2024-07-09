using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ILoginService
    {
        Task<UsuarioDto> LoginAsync(string nombreUsuario, string clave);
    }
}
