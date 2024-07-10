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
    internal class AtributoProductoService : IAtributoProductoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<AtributoProductoService> _logger;

        public AtributoProductoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<AtributoProductoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<AtributoProductoDto> RegistrarAtributoProducto(AtributoProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<AtributoProducto>(request);
                await context.AtributoProductos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<AtributoProductoDto>(entidad);
            }
        }

        public async Task<AtributoProductoDto> ActualizarAtributoProducto(int id, AtributoProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.AtributoProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("AtributoProducto no encontrada.");
                    throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<AtributoProductoDto>(entidad);
            }
        }

        public async Task EliminarAtributoProducto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.AtributoProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("AtributoProducto no encontrada.");
                    throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
                }

                context.AtributoProductos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<AtributoProductoDto>> ObtenerTodasAtributoProductos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.AtributoProductos
                                            .ProjectTo<AtributoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
