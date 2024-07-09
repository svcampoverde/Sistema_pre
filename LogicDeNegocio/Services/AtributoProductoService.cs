using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class AtributoProductoService : IAtributoProductoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public AtributoProductoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una AtributoProducto
        public async Task<AtributoProductoDto> RegistrarAtributoProducto(AtributoProductoRequest request)
        {
            var  = _mapper.Map<AtributoProducto>(request);
            await _sistemapContext.AtributoProductos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<AtributoProductoDto>();
        }

        // Método para actualizar una AtributoProducto
        public async Task<AtributoProductoDto> ActualizarAtributoProducto(int id, AtributoProductoRequest request)
        {
            var  = await _sistemapContext.AtributoProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.AtributoProductos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<AtributoProductoDto>();
        }

        // Método para eliminar una AtributoProducto
        public async Task EliminarAtributoProducto(int id)
        {
            var  = await _sistemapContext.AtributoProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
            }

            _sistemapContext.AtributoProductos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las AtributoProductos
        public async Task<List<AtributoProductoDto>> ObtenerTodasAtributoProductos()
        {
            var s = await _sistemapContext.AtributoProductos
                                            .ProjectTo<AtributoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
