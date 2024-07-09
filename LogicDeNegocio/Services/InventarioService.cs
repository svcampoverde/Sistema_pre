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
    internal class InventarioService : IInventarioService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public InventarioService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Inventario
        public async Task<InventarioDto> RegistrarInventario(InventarioRequest request)
        {
            var  = _mapper.Map<Inventario>(request);
            await _sistemapContext.Inventarios.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<InventarioDto>();
        }

        // Método para actualizar una Inventario
        public async Task<InventarioDto> ActualizarInventario(int id, InventarioRequest request)
        {
            var  = await _sistemapContext.Inventarios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Inventarios.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<InventarioDto>();
        }

        // Método para eliminar una Inventario
        public async Task EliminarInventario(int id)
        {
            var  = await _sistemapContext.Inventarios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
            }

            _sistemapContext.Inventarios.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Inventarios
        public async Task<List<InventarioDto>> ObtenerTodasInventarios()
        {
            var s = await _sistemapContext.Inventarios
                                            .ProjectTo<InventarioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
