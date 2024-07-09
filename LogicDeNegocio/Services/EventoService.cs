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
    internal class EventoService : IEventoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public EventoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Evento
        public async Task<EventoDto> RegistrarEvento(EventoRequest request)
        {
            var entidad = _mapper.Map<Evento>(request);
            await _sistemapContext.Eventos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EventoDto>(entidad);
        }

        // Método para actualizar una Evento
        public async Task<EventoDto> ActualizarEvento(int id, EventoRequest request)
        {
            var entidad = await _sistemapContext.Eventos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Eventos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EventoDto>(entidad);
        }

        // Método para eliminar una Evento
        public async Task EliminarEvento(int id)
        {
            var entidad = await _sistemapContext.Eventos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
            }

            _sistemapContext.Eventos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Eventos
        public async Task<List<EventoDto>> ObtenerTodasEventos()
        {
            var entidadDto = await _sistemapContext.Eventos
                                            .ProjectTo<EventoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}