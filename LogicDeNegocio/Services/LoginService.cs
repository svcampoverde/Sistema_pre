using AutoMapper;

using Datos.AplicationDB;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Threading.Tasks;

namespace LogicDeNegocio.Personas
{
    public class LoginService : ILoginService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<LoginService> _logger;
        private readonly IPasswordHashService _passwordHashService;

        public LoginService(
            Func<SistemapContext> dbContextFactory,
            IMapper mapper,
            ILogger<LoginService> logger,
            IPasswordHashService passwordHashService)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
            _passwordHashService = passwordHashService;
        }

        public async Task<UsuarioDto> LoginAsync(string nombreUsuario, string clave)
        {
            _logger.LogInformation("Inicio del método LoginAsync.");

            try
            {
                using (var context = _dbContextFactory())
                {
                    var usuario = await context.Usuarios
                        .Include(u => u.PersonaNavegation)
                        .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario);

                    if (usuario == null)
                    {
                        _logger.LogWarning("NombreUsuario no encontrado.");
                        throw new Exception("NombreUsuario o contraseña incorrectos.");
                    }

                    // Verificar el hash de la contraseña
                    if (!_passwordHashService.VerifyPasswordHash(clave, usuario.ContrasenaHash, usuario.ContrasenaSalt))
                    {
                        _logger.LogWarning("Contraseña incorrecta para el usuario {NombreUsuario}.", nombreUsuario);
                        throw new Exception("NombreUsuario o contraseña incorrectos.");
                    }

                    // Mapear a UsuarioRequest y devolver
                    var userDto = _mapper.Map<UsuarioDto>(usuario.PersonaNavegation);
                    _logger.LogInformation("Inicio de sesión exitoso para el usuario {NombreUsuario}.", nombreUsuario);
                    return userDto;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado durante el inicio de sesión.");
                throw new Exception("Ocurrió un error inesperado durante el inicio de sesión.", ex);
            }
        }
    }
}
