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
    internal class ProvinciaService : IProvinciaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ProvinciaService> _logger;

        public ProvinciaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<ProvinciaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProvinciaDto> RegistrarProvincia(ProvinciaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Provincia>(request);
                await context.Provincias.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProvinciaDto>(entidad);
            }
        }

        public async Task<ProvinciaDto> ActualizarProvincia(int id, ProvinciaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Provincias.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Provincia no encontrada.");
                    throw new KeyNotFoundException($"Provincia con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ProvinciaDto>(entidad);
            }
        }

        public async Task EliminarProvincia(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Provincias.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Provincia no encontrada.");
                    throw new KeyNotFoundException($"Provincia con ID {id} no encontrado.");
                }

                context.Provincias.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ProvinciaDto>> ObtenerTodasProvincias()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Provincias
                                            .ProjectTo<ProvinciaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
