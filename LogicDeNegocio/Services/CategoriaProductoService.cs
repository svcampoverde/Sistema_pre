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
    internal class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoriaProductoService> _logger;

        public CategoriaProductoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<CategoriaProductoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CategoriaProductoDto> RegistrarCategoriaProducto(CategoriaProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<CategoriaProducto>(request);
                await context.CategoriaProductos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CategoriaProductoDto>(entidad);
            }
        }

        public async Task<CategoriaProductoDto> ActualizarCategoriaProducto(int id, CategoriaProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.CategoriaProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("CategoriaProducto no encontrada.");
                    throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CategoriaProductoDto>(entidad);
            }
        }

        public async Task EliminarCategoriaProducto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.CategoriaProductos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("CategoriaProducto no encontrada.");
                    throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
                }

                context.CategoriaProductos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<CategoriaProductoDto>> ObtenerCategorias(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.CategoriaProductos.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<CategoriaProductoDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }

        public async Task<List<CategoriaProductoDto>> ObtenerTodasCategoriaProductos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.CategoriaProductos
                                            .ProjectTo<CategoriaProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
