using AutoMapper;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LogicDeNegocio.Personas
{
    public class LoginService : ILoginService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;
        private readonly ILogger<LoginService> _logger;
        private readonly IPasswordHashService _passwordHashService;

        public LoginService(SistemapContext sistemapContext, IMapper mapper,
            ILogger<LoginService> logger, IPasswordHashService passwordHashService)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
            _logger = logger;
            _passwordHashService = passwordHashService;
        }

        public async Task<UsuarioDto> LoginAsync(string nombreUsuario, string clave)
        {
            _logger.LogInformation("Inicio del método LoginAsync.");

            try
            {
                var usuario = await _sistemapContext.Usuarios
                    .Include(u => u.Persona)
                    .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario);

                if (usuario == null)
                {
                    _logger.LogWarning("Usuario no encontrado.");
                    throw new Exception("Usuario o contraseña incorrectos.");
                }

                // Verificar el hash de la contraseña
                if (!_passwordHashService.VerifyPasswordHash(clave, usuario.ContrasenaHash, usuario.ContrasenaSalt))
                {
                    _logger.LogWarning("Contraseña incorrecta para el usuario {NombreUsuario}.", nombreUsuario);
                    throw new Exception("Usuario o contraseña incorrectos.");
                }
                // Mapear a UsuarioRequest y devolver
                var userDto = _mapper.Map<UsuarioDto>(usuario.Persona);
                _logger.LogInformation("Inicio de sesión exitoso para el usuario {NombreUsuario}.", nombreUsuario);
                return userDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado durante el inicio de sesión.");
                throw new Exception("Ocurrió un error inesperado durante el inicio de sesión.", ex);
            }
        }
    }
}
