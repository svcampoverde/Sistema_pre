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
    internal class PresupuestoService : IPresupuestoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<PresupuestoService> _logger;

        public PresupuestoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<PresupuestoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PresupuestoDto> RegistrarPresupuesto(PresupuestoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Presupuesto>(request);
                await context.Presupuestos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PresupuestoDto>(entidad);
            }
        }

        public async Task<PresupuestoDto> ActualizarPresupuesto(int id, PresupuestoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Presupuestos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Presupuesto no encontrada.");
                    throw new KeyNotFoundException($"Presupuesto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PresupuestoDto>(entidad);
            }
        }

        public async Task EliminarPresupuesto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Presupuestos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Presupuesto no encontrada.");
                    throw new KeyNotFoundException($"Presupuesto con ID {id} no encontrado.");
                }

                context.Presupuestos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<PresupuestoDto>> ObtenerTodasPresupuestos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Presupuestos
                                            .ProjectTo<PresupuestoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
