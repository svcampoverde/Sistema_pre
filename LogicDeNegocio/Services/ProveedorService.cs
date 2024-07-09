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
    internal class ProveedorService : IProveedorService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public ProveedorService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Proveedor
        public async Task<ProveedorDto> RegistrarProveedor(ProveedorRequest request)
        {
            var entidad = _mapper.Map<Proveedor>(request);
            await _sistemapContext.Proveedores.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ProveedorDto>(entidad);
        }

        // Método para actualizar una Proveedor
        public async Task<ProveedorDto> ActualizarProveedor(int id, ProveedorRequest request)
        {
            var entidad = await _sistemapContext.Proveedores.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Proveedores.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ProveedorDto>(entidad);
        }

        // Método para eliminar una Proveedor
        public async Task EliminarProveedor(int id)
        {
            var entidad = await _sistemapContext.Proveedores.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
            }

            _sistemapContext.Proveedores.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Proveedores
        public async Task<List<ProveedorDto>> ObtenerTodasProveedors()
        {
            var entidadDto = await _sistemapContext.Proveedores
                                            .ProjectTo<ProveedorDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}