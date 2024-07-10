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
    internal class TipoEmpresaService : ITipoEmpresaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<TipoEmpresaService> _logger;

        public TipoEmpresaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<TipoEmpresaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TipoEmpresaDto> RegistrarTipoEmpresa(TipoEmpresaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<TipoEmpresa>(request);
                await context.TipoEmpresas.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoEmpresaDto>(entidad);
            }
        }

        public async Task<TipoEmpresaDto> ActualizarTipoEmpresa(int id, TipoEmpresaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoEmpresas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoEmpresa no encontrada.");
                    throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<TipoEmpresaDto>(entidad);
            }
        }

        public async Task EliminarTipoEmpresa(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.TipoEmpresas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("TipoEmpresa no encontrada.");
                    throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
                }

                context.TipoEmpresas.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TipoEmpresaDto>> ObtenerTodasTipoEmpresas()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.TipoEmpresas
                                            .ProjectTo<TipoEmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
