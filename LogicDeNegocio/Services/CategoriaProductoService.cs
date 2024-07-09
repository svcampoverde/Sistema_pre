using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public CategoriaProductoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una CategoriaProducto
        public async Task<CategoriaProductoDto> RegistrarCategoriaProducto(CategoriaProductoRequest request)
        {
            var entidad = _mapper.Map<CategoriaProducto>(request);
            await _sistemapContext.CategoriaProductos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CategoriaProductoDto>(entidad);
        }

        // Método para actualizar una CategoriaProducto
        public async Task<CategoriaProductoDto> ActualizarCategoriaProducto(int id, CategoriaProductoRequest request)
        {
            var entidad = await _sistemapContext.CategoriaProductos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.CategoriaProductos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CategoriaProductoDto>(entidad);
        }

        // Método para eliminar una CategoriaProducto
        public async Task EliminarCategoriaProducto(int id)
        {
            var entidad = await _sistemapContext.CategoriaProductos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
            }

            _sistemapContext.CategoriaProductos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las CategoriaProductos
        public async Task<List<CategoriaProductoDto>> ObtenerTodasCategoriaProductos()
        {
            var entidadDto = await _sistemapContext.CategoriaProductos
                                            .ProjectTo<CategoriaProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}