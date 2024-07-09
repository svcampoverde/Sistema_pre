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
            var  = _mapper.Map<Evento>(request);
            await _sistemapContext.Eventos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EventoDto>();
        }

        // Método para actualizar una Evento
        public async Task<EventoDto> ActualizarEvento(int id, EventoRequest request)
        {
            var  = await _sistemapContext.Eventos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Eventos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EventoDto>();
        }

        // Método para eliminar una Evento
        public async Task EliminarEvento(int id)
        {
            var  = await _sistemapContext.Eventos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Evento con ID {id} no encontrado.");
            }

            _sistemapContext.Eventos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Eventos
        public async Task<List<EventoDto>> ObtenerTodasEventos()
        {
            var s = await _sistemapContext.Eventos
                                            .ProjectTo<EventoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
