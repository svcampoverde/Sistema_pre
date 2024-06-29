using AutoMapper;
using Datos.AplicationDB;
using Datos.Models;
using FluentValidation;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Personas
{
    public class UserService : IUserService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;
        private readonly IValidator<UserDto> _validator;
        private readonly ILogger<UserService> _logger;

        public UserService(SistemapContext sistemapContext, IMapper mapper, IValidator<UserDto> validator, ILogger<UserService> logger)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
        }

        public async Task<UserDto> RegistrarUsuarioAsync(UserDto userDto)
        {
            _logger.LogInformation("Inicio del método RegistrarUsuarioAsync.");

            // Validar el DTO antes de mapear y guardar
            var validationResult = await _validator.ValidateAsync(userDto);

            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Errores de validación: {Errors}", validationResult.Errors);
                throw new ValidationException(validationResult.Errors);
            }

            try
            {
                var persona = _mapper.Map<Persona>(userDto);
                var user = _mapper.Map<Usuario>(userDto);
                persona.Usuarios = new List<Usuario>();
                persona.Usuarios.Add(user);
                await _sistemapContext.AddAsync(persona);
                await _sistemapContext.SaveChangesAsync();

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
    }
}
