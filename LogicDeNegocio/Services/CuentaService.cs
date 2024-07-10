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
    internal class CuentaService : ICuentaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<CuentaService> _logger;

        public CuentaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<CuentaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CuentaDto> RegistrarCuenta(CuentaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Cuenta>(request);
                await context.Cuentas.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CuentaDto>(entidad);
            }
        }

        public async Task<CuentaDto> ActualizarCuenta(int id, CuentaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Cuentas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Cuenta no encontrada.");
                    throw new KeyNotFoundException($"Cuenta con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CuentaDto>(entidad);
            }
        }

        public async Task EliminarCuenta(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Cuentas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Cuenta no encontrada.");
                    throw new KeyNotFoundException($"Cuenta con ID {id} no encontrado.");
                }

                context.Cuentas.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<CuentaDto>> ObtenerTodasCuentas()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Cuentas
                                            .ProjectTo<CuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
