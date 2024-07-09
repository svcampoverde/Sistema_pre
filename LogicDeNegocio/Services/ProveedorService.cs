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
            var  = _mapper.Map<Proveedor>(request);
            await _sistemapContext.Proveedors.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ProveedorDto>();
        }

        // Método para actualizar una Proveedor
        public async Task<ProveedorDto> ActualizarProveedor(int id, ProveedorRequest request)
        {
            var  = await _sistemapContext.Proveedors.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Proveedors.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ProveedorDto>();
        }

        // Método para eliminar una Proveedor
        public async Task EliminarProveedor(int id)
        {
            var  = await _sistemapContext.Proveedors.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
            }

            _sistemapContext.Proveedors.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Proveedors
        public async Task<List<ProveedorDto>> ObtenerTodasProveedors()
        {
            var s = await _sistemapContext.Proveedors
                                            .ProjectTo<ProveedorDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
