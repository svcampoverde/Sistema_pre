using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class ProveedorService : IProveedorService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ProveedorService> _logger;

        public ProveedorService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<ProveedorService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProveedorDto> RegistrarProveedor(ProveedorRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Proveedor>(request);
                await context.Proveedores.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProveedorDto>(entidad);
            }
        }

        public async Task<ProveedorDto> ActualizarProveedor(int id, ProveedorRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Proveedores.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Proveedor no encontrada.");
                    throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProveedorDto>(entidad);
            }
        }

        public async Task EliminarProveedor(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Proveedores.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Proveedor no encontrada.");
                    throw new KeyNotFoundException($"Proveedor con ID {id} no encontrado.");
                }

                context.Proveedores.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ProveedorDto>> ObtenerTodasProveedors()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Proveedores
                                            .ProjectTo<ProveedorDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
