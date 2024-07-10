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
    internal class InventarioService : IInventarioService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<InventarioService> _logger;

        public InventarioService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<InventarioService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<InventarioDto> RegistrarInventario(InventarioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Inventario>(request);
                await context.Inventarios.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<InventarioDto>(entidad);
            }
        }

        public async Task<InventarioDto> ActualizarInventario(int id, InventarioRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Inventarios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Inventario no encontrada.");
                    throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<InventarioDto>(entidad);
            }
        }

        public async Task EliminarInventario(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Inventarios.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Inventario no encontrada.");
                    throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
                }

                context.Inventarios.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<InventarioDto>> ObtenerTodasInventarios()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Inventarios
                                            .ProjectTo<InventarioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
