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
    internal class PresupuestoDetalleService : IPresupuestoDetalleService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<PresupuestoDetalleService> _logger;

        public PresupuestoDetalleService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<PresupuestoDetalleService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PresupuestoDetalleDto> RegistrarPresupuestoDetalle(PresupuestoDetalleRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<PresupuestoDetalle>(request);
                await context.PresupuestoDetalles.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PresupuestoDetalleDto>(entidad);
            }
        }

        public async Task<PresupuestoDetalleDto> ActualizarPresupuestoDetalle(int id, PresupuestoDetalleRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.PresupuestoDetalles.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("PresupuestoDetalle no encontrada.");
                    throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<PresupuestoDetalleDto>(entidad);
            }
        }

        public async Task EliminarPresupuestoDetalle(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.PresupuestoDetalles.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("PresupuestoDetalle no encontrada.");
                    throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
                }

                context.PresupuestoDetalles.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<PresupuestoDetalleDto>> ObtenerTodasPresupuestoDetalles()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.PresupuestoDetalles
                                            .ProjectTo<PresupuestoDetalleDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
