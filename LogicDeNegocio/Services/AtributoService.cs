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
    internal class AtributoService : IAtributoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<AtributoService> _logger;

        public AtributoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<AtributoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<AtributoDto> RegistrarAtributo(AtributoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Atributo>(request);
                await context.Atributos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<AtributoDto>(entidad);
            }
        }

        public async Task<AtributoDto> ActualizarAtributo(int id, AtributoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Atributos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Atributo no encontrada.");
                    throw new KeyNotFoundException($"Atributo con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<AtributoDto>(entidad);
            }
        }

        public async Task EliminarAtributo(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Atributos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Atributo no encontrada.");
                    throw new KeyNotFoundException($"Atributo con ID {id} no encontrado.");
                }

                context.Atributos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<AtributoDto>> ObtenerAtributos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Atributos
                                            .ProjectTo<AtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }

        public async Task<AtributoDto> ObtenerAtributoPorId(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Atributos
                .Where(x => x.Id == id)
                                            .ProjectTo<AtributoDto>(_mapper.ConfigurationProvider)
                                            .FirstOrDefaultAsync();
                return entidadDto;
            }
        }

        public async Task<List<AtributoDto>> BuscarArtributo(string search)
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Atributos
                .Where(x => x.Nombre.Contains(search))
                                            .ProjectTo<AtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
