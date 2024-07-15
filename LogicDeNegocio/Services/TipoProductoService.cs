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
    internal class TipoProductoService : ITipoProductoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<TipoProductoService> _logger;

        public TipoProductoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<TipoProductoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TipoProductoDto> RegistrarTipoProducto(TipoProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<TipoProducto>(request);
                await context.TipoProductos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoProductoDto>(entidad);
            }
        }
        public async Task<List<TipoProductoDto>> ObtenerTipoProducto(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.TipoProductos.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<TipoProductoDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }

        public async Task<TipoProductoDto> ActualizarTipoProducto(int id, TipoProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoProducto no encontrada.");
                    throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoProductoDto>(entidad);
            }
        }

        public async Task EliminarTipoProducto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoProducto no encontrada.");
                    throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
                }

                context.TipoProductos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TipoProductoDto>> ObtenerTodasTipoProductos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.TipoProductos
                                            .ProjectTo<TipoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
