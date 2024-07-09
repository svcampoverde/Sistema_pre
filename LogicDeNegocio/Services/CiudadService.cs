using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
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
    public class CiudadService : ICiudadService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;
        private readonly ILogger<CiudadService> _logger;

        public CiudadService(SistemapContext sistemapContext, IMapper mapper, ILogger<CiudadService> logger)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<CiudadDto>> ObtenerCiudadesAsync()
        {
            _logger.LogInformation("Inicio del método ObtenerCiudadesAsync.");
            var ciudades = await _sistemapContext.Ciudades.ToListAsync();
            return _mapper.Map<IEnumerable<CiudadDto>>(ciudades);
        }

        public async Task<CiudadDto> ObtenerCiudadPorIdAsync(int id)
        {
            _logger.LogInformation("Inicio del método ObtenerCiudadPorIdAsync.");
            var ciudad = await _sistemapContext.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                _logger.LogWarning("Ciudad no encontrada.");
                throw new KeyNotFoundException("Ciudad no encontrada.");
            }
            return _mapper.Map<CiudadDto>(ciudad);
        }

        public async Task<CiudadDto> CrearCiudadAsync(CiudadRequest ciudadRequest)
        {
            _logger.LogInformation("Inicio del método CrearCiudadAsync.");
            var ciudad = _mapper.Map<Ciudad>(ciudadRequest);
            await _sistemapContext.Ciudades.AddAsync(ciudad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CiudadDto>(ciudad);
        }

        public async Task<CiudadDto> ActualizarCiudadAsync(int id, CiudadRequest ciudadRequest)
        {
            _logger.LogInformation("Inicio del método ActualizarCiudadAsync.");
            var ciudad = await _sistemapContext.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                _logger.LogWarning("Ciudad no encontrada.");
                throw new KeyNotFoundException("Ciudad no encontrada.");
            }
            _mapper.Map(ciudadRequest, ciudad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CiudadDto>(ciudad);
        }

        public async Task<bool> EliminarCiudadAsync(int id)
        {
            _logger.LogInformation("Inicio del método EliminarCiudadAsync.");
            var ciudad = await _sistemapContext.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                _logger.LogWarning("Ciudad no encontrada.");
                throw new KeyNotFoundException("Ciudad no encontrada.");
            }
            _sistemapContext.Ciudades.Remove(ciudad);
            await _sistemapContext.SaveChangesAsync();
            return true;
        }

        public async Task<Paginate<CiudadDto>> ObtenerCiudadesPaginadasAsync(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // Preparar la consulta con proyección temprana
                var query = _sistemapContext.Ciudades
                                    .Include(c => c.ProvinciaNavigation)
                                    .AsNoTracking();

                // Aplicar el filtro si es necesario
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(c => c.Nombre.Contains(search) || c.ProvinciaNavigation.Nombre.Contains(search));
                }

                // Ejecutar la consulta para contar los registros
                var count = await query.CountAsync();

                // Ejecutar la consulta para obtener los registros paginados
                var items = await query
                                .OrderBy(c => c.Id) // Ordenar por algún criterio si es necesario
                                .Skip((pageIndex - 1) * pageSize)
                                .Take(pageSize)
                                .ProjectTo<CiudadDto>(_mapper.ConfigurationProvider)
                                .ToListAsync();

                // Crear y devolver la instancia de Paginate
                return new Paginate<CiudadDto>(items, count, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                // Manejar excepciones si es necesario
                _logger.LogError(ex, "Error al obtener ciudades paginadas.");
                throw;
            }
        }
    }
}
