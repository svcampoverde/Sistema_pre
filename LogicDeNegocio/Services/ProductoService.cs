using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    public class ProductoService : IProductoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public ProductoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        public async Task<ProductoDto> RegistrarProducto(ProductoRequest request)
        {
            var producto = _mapper.Map<Producto>(request);
            await _sistemapContext.Productos.AddAsync(producto);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ProductoDto>(producto);
        }

        public async Task<ProductoDto> ActualizarProducto(int id, ProductoRequest request)
        {
            var producto = await ObtenerProductoPorIdAsync(id);
            if (producto == null)
            {
                throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
            }

            _mapper.Map(request, producto);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ProductoDto>(producto);
        }

        public async Task EliminarProducto(int id)
        {
            var producto = await ObtenerProductoPorIdAsync(id);
            if (producto == null)
            {
                throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
            }

            _sistemapContext.Productos.Remove(producto);
            await _sistemapContext.SaveChangesAsync();
        }

        public async Task<Paginate<ProductoDto>> GetProductosPaginados(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                var query = _sistemapContext.Productos
                                    .Include(p => p.CategoriaProducto)
                                    .Include(p => p.TipoProducto)
                                    .AsNoTracking();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(p => p.Descripcion.Contains(search));
                }

                var count = await query.CountAsync();

                var items = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ProjectTo<ProductoDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();

                return new Paginate<ProductoDto>(items, count, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos paginados", ex);
            }
        }

        public async Task<ProductoDto> ObtenerProductoDtoPorIdAsync(int id)
        {
            try
            {
                Producto producto = await ObtenerProductoPorIdAsync(id);

                return _mapper.Map<ProductoDto>(producto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el producto con ID {id}", ex);
            }
        }

        private async Task<Producto> ObtenerProductoPorIdAsync(int id)
        {
            return await _sistemapContext.Productos
                                                .Include(p => p.CategoriaProducto)
                                                .Include(p => p.TipoProducto)
                                                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<ProductoDto>> ObtenerTodosLosProductos()
        {
            try
            {
                var productos = await _sistemapContext.Productos
                                    .Include(p => p.CategoriaProducto)
                                    .Include(p => p.TipoProducto)
                                    .AsNoTracking()
                                    .ProjectTo<ProductoDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los productos", ex);
            }
        }

        public int GetTotalProductos()
        {
            return _sistemapContext.Productos.Count();
        }
    }
}
