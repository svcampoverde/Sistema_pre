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
    internal class PersonaService : IPersonaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public PersonaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Persona
        public async Task<PersonaDto> RegistrarPersona(PersonaRequest request)
        {
            var  = _mapper.Map<Persona>(request);
            await _sistemapContext.Personas.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<PersonaDto>();
        }

        // Método para actualizar una Persona
        public async Task<PersonaDto> ActualizarPersona(int id, PersonaRequest request)
        {
            var  = await _sistemapContext.Personas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Personas.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<PersonaDto>();
        }

        // Método para eliminar una Persona
        public async Task EliminarPersona(int id)
        {
            var  = await _sistemapContext.Personas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
            }

            _sistemapContext.Personas.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Personas
        public async Task<List<PersonaDto>> ObtenerTodasPersonas()
        {
            var s = await _sistemapContext.Personas
                                            .ProjectTo<PersonaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
