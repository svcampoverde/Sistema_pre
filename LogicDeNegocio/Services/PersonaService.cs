using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
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
            var entidad = _mapper.Map<Persona>(request);
            await _sistemapContext.Personas.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<PersonaDto>(entidad);
        }

        // Método para actualizar una Persona
        public async Task<PersonaDto> ActualizarPersona(int id, PersonaRequest request)
        {
            var entidad = await _sistemapContext.Personas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Personas.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<PersonaDto>(entidad);
        }

        // Método para eliminar una Persona
        public async Task EliminarPersona(int id)
        {
            var entidad = await _sistemapContext.Personas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
            }

            _sistemapContext.Personas.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Personas
        public async Task<List<PersonaDto>> ObtenerTodasPersonas()
        {
            var entidadDto = await _sistemapContext.Personas
                                            .ProjectTo<PersonaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}