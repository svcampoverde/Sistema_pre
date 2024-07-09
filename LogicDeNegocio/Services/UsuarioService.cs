using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class UsuarioService : IUsuarioService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public UsuarioService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Usuario
        public async Task<UsuarioDto> RegistrarUsuario(UsuarioRequest request)
        {
            var  = _mapper.Map<Usuario>(request);
            await _sistemapContext.Usuarios.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<UsuarioDto>();
        }

        // Método para actualizar una Usuario
        public async Task<UsuarioDto> ActualizarUsuario(int id, UsuarioRequest request)
        {
            var  = await _sistemapContext.Usuarios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Usuario con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Usuarios.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<UsuarioDto>();
        }

        // Método para eliminar una Usuario
        public async Task EliminarUsuario(int id)
        {
            var  = await _sistemapContext.Usuarios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Usuario con ID {id} no encontrado.");
            }

            _sistemapContext.Usuarios.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Usuarios
        public async Task<List<UsuarioDto>> ObtenerTodasUsuarios()
        {
            var s = await _sistemapContext.Usuarios
                                            .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
