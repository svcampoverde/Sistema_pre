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
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class ProductoService : IProductoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductoService> _logger;
        
        public ProductoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<ProductoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductoDto> RegistrarProducto(ProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Producto>(request);
                await context.Productos.AddAsync(entidad);
                await context.SaveChangesAsync();
               // return _mapper.Map<ProductoDto>(entidad);
               var productodto = _mapper.Map<ProductoDto>(entidad);
                productodto.Id=entidad.Id;
                return productodto;
            }
        }
        public async Task<int> RegistrarProductos(ProductoRequest request)
        {
            var producto = new Producto
            {
                Nombre = request.Nombre,
                Descripcion = request.Descripcion,
                Precio=request.Precio,
                IdTipoProducto = request.IdTipoProducto,
                IdCategoriaProducto = request.IdCategoriaProducto,
            };

            _dbContextFactory().Productos.Add(producto);
            await _dbContextFactory().SaveChangesAsync();

            return producto.Id; // Devolver el ID generado
        }

    public async Task<ProductoDto> ActualizarProducto(int id, ProductoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Productos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Producto no encontrada.");
                    throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProductoDto>(entidad);
            }
        }

        public async Task EliminarProducto(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Productos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Producto no encontrada.");
                    throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
                }

                context.Productos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ProductoDto>> ObtenerTodoslosProductos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Productos
                                            .ProjectTo<ProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
