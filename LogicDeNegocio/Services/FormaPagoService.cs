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
    internal class FormaPagoService : IFormaPagoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<FormaPagoService> _logger;

        public FormaPagoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<FormaPagoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<FormaPagoDto> RegistrarFormaPago(FormaPagoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<FormaPago>(request);
                await context.FormaPagos.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<FormaPagoDto>(entidad);
            }
        }

        public async Task<FormaPagoDto> ActualizarFormaPago(int id, FormaPagoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.FormaPagos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("FormaPago no encontrada.");
                    throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<FormaPagoDto>(entidad);
            }
        }
        public async Task<List<FormaPagoDto>> ObtenerListForPage(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.FormaPagos.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato) || te.Nombre.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<FormaPagoDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }

        public async Task EliminarFormaPago(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.FormaPagos.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("FormaPago no encontrada.");
                    throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
                }

                context.FormaPagos.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<FormaPagoDto>> ObtenerTodasFormaPagos()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.FormaPagos
                                            .ProjectTo<FormaPagoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
