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
            var  = _mapper.Map<CategoriaProducto>(request);
            await _sistemapContext.CategoriaProductos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CategoriaProductoDto>();
        }

        // Método para actualizar una CategoriaProducto
        public async Task<CategoriaProductoDto> ActualizarCategoriaProducto(int id, CategoriaProductoRequest request)
        {
            var  = await _sistemapContext.CategoriaProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.CategoriaProductos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CategoriaProductoDto>();
        }

        // Método para eliminar una CategoriaProducto
        public async Task EliminarCategoriaProducto(int id)
        {
            var  = await _sistemapContext.CategoriaProductos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"CategoriaProducto con ID {id} no encontrado.");
            }

            _sistemapContext.CategoriaProductos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las CategoriaProductos
        public async Task<List<CategoriaProductoDto>> ObtenerTodasCategoriaProductos()
        {
            var s = await _sistemapContext.CategoriaProductos
                                            .ProjectTo<CategoriaProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
