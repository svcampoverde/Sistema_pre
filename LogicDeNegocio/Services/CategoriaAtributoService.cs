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
    internal class CategoriaAtributoService : ICategoriaAtributoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoriaAtributoService> _logger;

        public CategoriaAtributoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<CategoriaAtributoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CategoriaAtributoDto> RegistrarCategoriaAtributo(CategoriaAtributoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<CategoriaAtributo>(request);
                await context.CategoriaAtributos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CategoriaAtributoDto>(entidad);
            }
        }

        public async Task<CategoriaAtributoDto> ActualizarCategoriaAtributo(int id, CategoriaAtributoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.CategoriaAtributos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("CategoriaAtributo no encontrada.");
                    throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<CategoriaAtributoDto>(entidad);
            }
        }

        public async Task EliminarCategoriaAtributo(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.CategoriaAtributos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("CategoriaAtributo no encontrada.");
                    throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
                }

                context.CategoriaAtributos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<CategoriaAtributoDto>> ObtenerTodasCategoriaAtributos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.CategoriaAtributos
                                            .ProjectTo<CategoriaAtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
