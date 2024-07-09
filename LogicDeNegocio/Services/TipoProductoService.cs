using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var  = _mapper.Map<TipoProducto>(request);
            await _sistemapContext.TipoProductos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoProductoDto>();
        }

        // Método para actualizar una TipoProducto
        public async Task<TipoProductoDto> ActualizarTipoProducto(int id, TipoProductoRequest request)
        {
            var  = await _sistemapContext.TipoProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.TipoProductos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoProductoDto>();
        }

        // Método para eliminar una TipoProducto
        public async Task EliminarTipoProducto(int id)
        {
            var  = await _sistemapContext.TipoProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoProducto con ID {id} no encontrado.");
            }

            _sistemapContext.TipoProductos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoProductos
        public async Task<List<TipoProductoDto>> ObtenerTodasTipoProductos()
        {
            var s = await _sistemapContext.TipoProductos
                                            .ProjectTo<TipoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
