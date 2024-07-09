using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
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
            var  = _mapper.Map<Empleado>(request);
            await _sistemapContext.Empleados.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EmpleadoDto>();
        }

        // Método para actualizar una Empleado
        public async Task<EmpleadoDto> ActualizarEmpleado(int id, EmpleadoRequest request)
        {
            var  = await _sistemapContext.Empleados.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Empleados.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EmpleadoDto>();
        }

        // Método para eliminar una Empleado
        public async Task EliminarEmpleado(int id)
        {
            var  = await _sistemapContext.Empleados.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Empleado con ID {id} no encontrado.");
            }

            _sistemapContext.Empleados.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Empleados
        public async Task<List<EmpleadoDto>> ObtenerTodasEmpleados()
        {
            var s = await _sistemapContext.Empleados
                                            .ProjectTo<EmpleadoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
