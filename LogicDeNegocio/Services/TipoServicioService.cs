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
    internal class TipoServicioService : ITipoServicioService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<TipoServicioService> _logger;

        public TipoServicioService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<TipoServicioService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TipoServicioDto> RegistrarTipoServicio(TipoServicioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<TipoServicio>(request);
                await context.TipoServicios.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoServicioDto>(entidad);
            }
        }

        public async Task<TipoServicioDto> ActualizarTipoServicio(int id, TipoServicioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoServicios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoServicio no encontrada.");
                    throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoServicioDto>(entidad);
            }
        }

        public async Task EliminarTipoServicio(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoServicios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoServicio no encontrada.");
                    throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
                }

                context.TipoServicios.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<TipoServicioDto>> ObtenerListServicio(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.TipoServicios.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<TipoServicioDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }

        public async Task<List<TipoServicioDto>> ObtenerTodasTipoServicios()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.TipoServicios
                                            .ProjectTo<TipoServicioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
