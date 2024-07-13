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
    internal class EventoService : IEventoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<EventoService> _logger;

        public EventoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<EventoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<EventoDto> RegistrarEvento(EventoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Evento>(request);
                await context.Eventos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EventoDto>(entidad);
            }
        }

        public async Task<EventoDto> ActualizarEvento(int id, EventoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Eventos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Evento no encontrada.");
                    throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EventoDto>(entidad);
            }
        }

        public async Task EliminarEvento(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Eventos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Evento no encontrada.");
                    throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
                }

                context.Eventos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<EventoDto>> ObtenerListEvent(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.Eventos.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato)|| te.Nombre.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<EventoDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }
        public async Task<List<EventoDto>> ObtenerTodasEventos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Eventos
                                            .ProjectTo<EventoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
