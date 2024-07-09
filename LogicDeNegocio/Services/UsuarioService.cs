using AutoMapper;

using Datos.AplicationDB;
using Datos.Models;

using FluentValidation;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Threading.Tasks;

namespace LogicDeNegocio.Personas
{
    public class UsuarioService : IUsuarioService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;
        private readonly IValidator<UsuarioRequest> _validator;
        private readonly ILogger<UsuarioService> _logger;
        private readonly IPasswordHashService _passwordHashService;

        public UsuarioService(SistemapContext sistemapContext, IMapper mapper,
            IValidator<UsuarioRequest> validator, ILogger<UsuarioService> logger,
            IPasswordHashService passwordHashService)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
            _passwordHashService = passwordHashService;
        }

        public async Task<UsuarioDto> RegistrarUsuarioAsync(UsuarioRequest request)
        {
            _logger.LogInformation("Inicio del método RegistrarUsuarioAsync.");

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Errores de validación: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            try
            {
                var persona = _mapper.Map<Persona>(request);
                var user = _mapper.Map<Usuario>(request);

                // Crear el hash y el salt de la contraseña
                _passwordHashService.CreatePasswordHash(request.Clave, out byte[] passwordHash, out byte[] passwordSalt);
                user.ContrasenaHash = passwordHash;
                user.ContrasenaSalt = passwordSalt;

                persona.UsuarioNavegation = user;
                await _sistemapContext.AddAsync(persona);
                await _sistemapContext.SaveChangesAsync();
                var userDto = _mapper.Map<UsuarioDto>(persona);

                _logger.LogInformation("Usuario registrado exitosamente.");
                return userDto;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al registrar el usuario. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al registrar el usuario.");
                throw new Exception("Ocurrió un error inesperado al registrar el usuario.", ex);
            }
        }

        public async Task<UsuarioDto> ActualizarUsuarioAsync(int id, UsuarioRequest request)
        {
            _logger.LogInformation("Inicio del método ActualizarUsuarioAsync.");

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Errores de validación: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            try
            {
                var persona = await _sistemapContext.Personas.Include(p => p.UsuarioNavegation).FirstOrDefaultAsync(p => p.Id == id);
                if (persona == null)
                {
                    _logger.LogWarning("Usuario no encontrado.");
                    throw new Exception("Usuario no encontrado.");
                }

                _mapper.Map(request, persona);
                var user = persona.UsuarioNavegation;
                _mapper.Map(request, user);

                // Actualizar la contraseña si se proporciona una nueva
                if (!string.IsNullOrEmpty(request.Clave))
                {
                    _passwordHashService.CreatePasswordHash(request.Clave, out byte[] passwordHash, out byte[] passwordSalt);
                    user.ContrasenaHash = passwordHash;
                    user.ContrasenaSalt = passwordSalt;
                }

                await _sistemapContext.SaveChangesAsync();
                var userDto = _mapper.Map<UsuarioDto>(persona);
                _logger.LogInformation("Usuario actualizado exitosamente.");
                return userDto;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al actualizar el usuario. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al actualizar el usuario.");
                throw new Exception("Ocurrió un error inesperado al actualizar el usuario.", ex);
            }
        }

        public async Task<bool> CambiarClaveAsync(int id, string nuevaClave)
        {
            _logger.LogInformation("Inicio del método CambiarClaveAsync.");

            try
            {
                var usuario = await _sistemapContext.Usuarios.FindAsync(id);
                if (usuario == null)
                {
                    _logger.LogWarning("Usuario no encontrado.");
                    throw new Exception("Usuario no encontrado.");
                }

                // Crear el hash y el salt de la nueva contraseña
                _passwordHashService.CreatePasswordHash(nuevaClave, out byte[] passwordHash, out byte[] passwordSalt);
                usuario.ContrasenaHash = passwordHash;
                usuario.ContrasenaSalt = passwordSalt;

                await _sistemapContext.SaveChangesAsync();
                _logger.LogInformation("Contraseña cambiada exitosamente.");
                return true;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error al actualizar la base de datos.");
                throw new Exception("Error al cambiar la contraseña. Intente nuevamente más tarde.", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al cambiar la contraseña.");
                throw new Exception("Ocurrió un error inesperado al cambiar la contraseña.", ex);
            }
        }
    }
}