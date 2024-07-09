using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class EmpleadoService : IEmpleadoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public EmpleadoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Empleado
        public async Task<EmpleadoDto> RegistrarEmpleado(EmpleadoRequest request)
        {
            var entidad = _mapper.Map<Empleado>(request);
            await _sistemapContext.Empleados.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EmpleadoDto>(entidad);
        }

        // Método para actualizar una Empleado
        public async Task<EmpleadoDto> ActualizarEmpleado(int id, EmpleadoRequest request)
        {
            var entidad = await _sistemapContext.Empleados.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Empleados.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EmpleadoDto>(entidad);
        }

        // Método para eliminar una Empleado
        public async Task EliminarEmpleado(int id)
        {
            var entidad = await _sistemapContext.Empleados.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
            }

            _sistemapContext.Empleados.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Empleados
        public async Task<List<EmpleadoDto>> ObtenerTodasEmpleados()
        {
            var entidadDto = await _sistemapContext.Empleados
                                            .ProjectTo<EmpleadoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}