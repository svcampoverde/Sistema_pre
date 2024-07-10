using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class PersonaService : IPersonaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonaService> _logger;

        public PersonaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<PersonaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PersonaDto> RegistrarPersona(PersonaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Persona>(request);
                await context.Personas.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PersonaDto>(entidad);
            }
        }

        public async Task<PersonaDto> ActualizarPersona(int id, PersonaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Personas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Persona no encontrada.");
                    throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PersonaDto>(entidad);
            }
        }

        public async Task EliminarPersona(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Personas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Persona no encontrada.");
                    throw new KeyNotFoundException($"Persona con ID {id} no encontrado.");
                }

                context.Personas.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<PersonaDto>> ObtenerTodasPersonas()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Personas
                                            .ProjectTo<PersonaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
