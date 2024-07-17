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
        public async Task<List<EmpleadoDto>> ObtenerEmpleados(string emp)
        {
            using (var context = _dbContextFactory())
            {
                var query = from p in context.Personas
                            join emple in context.Empleados on p.Id equals emple.IdPersona
                            join ciu in context.Ciudades on p.IdCiudad equals ciu.Id
                            where p.Activo == true
                            select new
                            {
                                emple.Id,
                                p.Cedula,
                                p.Nombre,
                                p.Apellido,
                                p.Genero,
                                p.Telefono,
                                p.Celular,
                                p.Correo,
                                p.Direccion,
                                Ciudaddescripcion = ciu.Nombre,
                                emple.Sueldo,
                                emple.Empresa,
                                emple.FechaContrato,
                            };
                if (!string.IsNullOrEmpty(emp))
                {
                    query = query.Where(e => e.Cedula.Contains(emp));
                }
                var datos = await query.ToListAsync();
                return datos.Select(d => new EmpleadoDto
                {
                    Id = d.Id,
                    Cedula = d.Cedula,
                    Nombre = d.Nombre,
                    Apellido = d.Apellido,
                    Celular = d.Celular,
                    Telefono = d.Telefono,
                    Genero = d.Genero,
                    Correo = d.Correo,
                    Direccion = d.Direccion,
                    Empresa = d.Empresa,
                    Sueldo = Convert.ToDecimal(d.Sueldo),
                    FechaContrato = d.FechaContrato,
                    CiudadDescripcion = d.Ciudaddescripcion
                }).ToList();

            }
        }
        public async Task<EmpleadoDto> ObtenerEmpleadoPorId(int id)
        {
            using (var context = _dbContextFactory())
            {
                // Buscar la entidad del empleado por su ID
                var entidad = await context.Empleados.FindAsync(id);

                if (entidad == null)
                {
                    _logger.LogWarning($"Empleado con ID {id} no encontrado.");
                    throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
                }

                // Mapear la entidad del empleado al DTO
                var empleadoDto = new EmpleadoDto
                {
                    Id = entidad.Id,
                    IdPersona = entidad.IdPersona,
                };

                return empleadoDto;
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
