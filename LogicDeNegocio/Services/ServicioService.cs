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
    internal class ServicioService : IServicioService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public ServicioService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Servicio
        public async Task<ServicioDto> RegistrarServicio(ServicioRequest request)
        {
            var  = _mapper.Map<Servicio>(request);
            await _sistemapContext.Servicios.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ServicioDto>();
        }

        // Método para actualizar una Servicio
        public async Task<ServicioDto> ActualizarServicio(int id, ServicioRequest request)
        {
            var  = await _sistemapContext.Servicios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Servicio con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Servicios.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ServicioDto>();
        }

        // Método para eliminar una Servicio
        public async Task EliminarServicio(int id)
        {
            var  = await _sistemapContext.Servicios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Servicio con ID {id} no encontrado.");
            }

            _sistemapContext.Servicios.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Servicios
        public async Task<List<ServicioDto>> ObtenerTodasServicios()
        {
            var s = await _sistemapContext.Servicios
                                            .ProjectTo<ServicioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
