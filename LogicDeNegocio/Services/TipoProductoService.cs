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
    internal class TipoProductoService : ITipoProductoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public TipoProductoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una TipoProducto
        public async Task<TipoProductoDto> RegistrarTipoProducto(TipoProductoRequest request)
        {
            var entidad = _mapper.Map<TipoProducto>(request);
            await _sistemapContext.TipoProductos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoProductoDto>(entidad);
        }

        // Método para actualizar una TipoProducto
        public async Task<TipoProductoDto> ActualizarTipoProducto(int id, TipoProductoRequest request)
        {
            var entidad = await _sistemapContext.TipoProductos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.TipoProductos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoProductoDto>(entidad);
        }

        // Método para eliminar una TipoProducto
        public async Task EliminarTipoProducto(int id)
        {
            var entidad = await _sistemapContext.TipoProductos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
            }

            _sistemapContext.TipoProductos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoProductos
        public async Task<List<TipoProductoDto>> ObtenerTodasTipoProductos()
        {
            var entidadDto = await _sistemapContext.TipoProductos
                                            .ProjectTo<TipoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}