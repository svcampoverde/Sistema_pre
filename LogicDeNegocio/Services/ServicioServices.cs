using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class ServicioServices : IServicioServices
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public ServicioServices(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar un servicio
        public async Task<ServicioDto> RegistrarServicio(ServicioRequest request)
        {
            var servicio = _mapper.Map<Servicio>(request);
            await _sistemapContext.Servicios.AddAsync(servicio);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ServicioDto>(servicio);
        }

        // Método para actualizar un servicio
        public async Task<ServicioDto> ActualizarServicio(int id, ServicioRequest request)
        {
            var servicio = await _sistemapContext.Servicios.FindAsync(id);
            if(servicio == null)
            {
                throw new KeyNotFoundException($"Servicio con ID {id} no encontrado.");
            }

            _mapper.Map(request, servicio);
            _sistemapContext.Servicios.Update(servicio);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ServicioDto>(servicio);
        }

        // Método para eliminar un servicio
        public async Task EliminarServicio(int id)
        {
            var servicio = await _sistemapContext.Servicios.FindAsync(id);
            if (servicio == null)
            {
                throw new KeyNotFoundException($"Servicio con ID {id} no encontrado.");
            }

            _sistemapContext.Servicios.Remove(servicio);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener servicios paginados
        public async Task<Paginate<ServicioDto>> GetServicioPaginate(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // Preparar la consulta con proyección temprana
                var query = _sistemapContext.Servicios
                                    .AsNoTracking();

                // Aplicar el filtro si es necesario
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x => x.Descripcion.Contains(search));
                }

                // Ejecutar la consulta para contar los registros
                var count = await query.CountAsync();

                // Ejecutar la consulta para obtener los registros paginados
                var items = await query
                                .Skip((pageIndex - 1) * pageSize)
                                .Take(pageSize)
                                .ProjectTo<ServicioDto>(_mapper.ConfigurationProvider)
                                .ToListAsync();

                // Crear y devolver la instancia de Paginate
                return new Paginate<ServicioDto>(items, count, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                // Manejar excepciones si es necesario
                throw new Exception("Error al obtener servicios paginados", ex);
            }
        }

        public int GetTotalServicios()
        {
            return _sistemapContext.Servicios.Count();
        }
    }
}
