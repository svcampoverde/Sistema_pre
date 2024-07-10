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
    internal class CiudadService : ICiudadService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<CiudadService> _logger;

        public CiudadService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<CiudadService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CiudadDto> RegistrarCiudad(CiudadRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Ciudad>(request);
                await context.Ciudades.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CiudadDto>(entidad);
            }
        }

        public async Task<CiudadDto> ActualizarCiudad(int id, CiudadRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Ciudades.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Ciudad no encontrada.");
                    throw new KeyNotFoundException($"Ciudad con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CiudadDto>(entidad);
            }
        }

        public async Task EliminarCiudad(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Ciudades.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Ciudad no encontrada.");
                    throw new KeyNotFoundException($"Ciudad con ID {id} no encontrado.");
                }

                context.Ciudades.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<CiudadDto>> obtenerCiudades()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Ciudades
                                            .ProjectTo<CiudadDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
