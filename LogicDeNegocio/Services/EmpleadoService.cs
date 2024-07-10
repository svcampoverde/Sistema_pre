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
    internal class EmpleadoService : IEmpleadoService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<EmpleadoService> _logger;

        public EmpleadoService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<EmpleadoService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<EmpleadoDto> RegistrarEmpleado(EmpleadoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Empleado>(request);
                await context.Empleados.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EmpleadoDto>(entidad);
            }
        }

        public async Task<EmpleadoDto> ActualizarEmpleado(int id, EmpleadoRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Empleados.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Empleado no encontrada.");
                    throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EmpleadoDto>(entidad);
            }
        }

        public async Task EliminarEmpleado(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Empleados.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Empleado no encontrada.");
                    throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
                }

                context.Empleados.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<EmpleadoDto>> ObtenerTodasEmpleados()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Empleados
                                            .ProjectTo<EmpleadoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
