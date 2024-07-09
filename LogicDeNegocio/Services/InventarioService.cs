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
            var entidad = _mapper.Map<Inventario>(request);
            await _sistemapContext.Inventarios.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<InventarioDto>(entidad);
        }

        // Método para actualizar una Inventario
        public async Task<InventarioDto> ActualizarInventario(int id, InventarioRequest request)
        {
            var entidad = await _sistemapContext.Inventarios.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Inventarios.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<InventarioDto>(entidad);
        }

        // Método para eliminar una Inventario
        public async Task EliminarInventario(int id)
        {
            var entidad = await _sistemapContext.Inventarios.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Inventario con ID {id} no encontrado.");
            }

            _sistemapContext.Inventarios.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Inventarios
        public async Task<List<InventarioDto>> ObtenerTodasInventarios()
        {
            var entidadDto = await _sistemapContext.Inventarios
                                            .ProjectTo<InventarioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}