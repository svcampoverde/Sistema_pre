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
    internal class BancoService : IBancoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<BancoService> _logger;

        public BancoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<BancoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<BancoDto> RegistrarBanco(BancoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Banco>(request);
                await context.Bancos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<BancoDto>(entidad);
            }
        }

        public async Task<BancoDto> ActualizarBanco(int id, BancoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Bancos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Banco no encontrada.");
                    throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<BancoDto>(entidad);
            }
        }

        public async Task EliminarBanco(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Bancos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Banco no encontrada.");
                    throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
                }

                context.Bancos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<BancoDto>> ObtenerBancos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Bancos
                                            .ProjectTo<BancoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
