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
    internal class TipoCuentaService : ITipoCuentaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<TipoCuentaService> _logger;

        public TipoCuentaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<TipoCuentaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TipoCuentaDto> RegistrarTipoCuenta(TipoCuentaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<TipoCuenta>(request);
                await context.TipoCuentas.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoCuentaDto>(entidad);
            }
        }

        public async Task<TipoCuentaDto> ActualizarTipoCuenta(int id, TipoCuentaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoCuentas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoCuenta no encontrada.");
                    throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoCuentaDto>(entidad);
            }
        }

        public async Task EliminarTipoCuenta(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoCuentas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoCuenta no encontrada.");
                    throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
                }

                context.TipoCuentas.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TipoCuentaDto>> ObtenerTodasTipoCuentas()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.TipoCuentas
                                            .ProjectTo<TipoCuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
