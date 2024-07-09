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
    public class ProvinciaService : IProvinciaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ProvinciaService> _logger;

        public ProvinciaService(SistemapContext sistemapContext, IMapper mapper, ILogger<ProvinciaService> logger)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<ProvinciaDto>> ObtenerProvinciasAsync()
        {
            _logger.LogInformation("Inicio del método ObtenerProvinciasAsync.");
            var provincias = await _sistemapContext.Provincias.ToListAsync();
            return _mapper.Map<IEnumerable<ProvinciaDto>>(provincias);
        }

        public async Task<ProvinciaDto> ObtenerProvinciaPorIdAsync(int id)
        {
            _logger.LogInformation("Inicio del método ObtenerProvinciaPorIdAsync.");
            var provincia = await _sistemapContext.Provincias.FindAsync(id);
            if (provincia == null)
            {
                _logger.LogWarning("Provincia no encontrada.");
                throw new KeyNotFoundException("Provincia no encontrada.");
            }
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task<ProvinciaDto> RegistrarProvincia(ProvinciaRequest provinciaRequest)
        {
            _logger.LogInformation("Inicio del método CrearProvinciaAsync.");
            var provincia = _mapper.Map<Provincia>(provinciaRequest);
            await _sistemapContext.Provincias.AddAsync(provincia);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task<ProvinciaDto> ActualizarProvincia(int id, ProvinciaRequest provinciaRequest)
        {
            _logger.LogInformation("Inicio del método ActualizarProvinciaAsync.");
            var provincia = await _sistemapContext.Provincias.FindAsync(id);
            if (provincia == null)
            {
                _logger.LogWarning("Provincia no encontrada.");
                throw new KeyNotFoundException("Provincia no encontrada.");
            }
            _mapper.Map(provinciaRequest, provincia);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ProvinciaDto>(provincia);
        }

        public async Task EliminarProvincia(int id)
        {
            _logger.LogInformation("Inicio del método EliminarProvincia.");
            var provincia = await _sistemapContext.Provincias.FindAsync(id);
            if (provincia == null)
            {
                _logger.LogWarning("Provincia no encontrada.");
                throw new KeyNotFoundException("Provincia no encontrada.");
            }
            _sistemapContext.Provincias.Remove(provincia);
            await _sistemapContext.SaveChangesAsync();
         }

        public async Task<Paginate<ProvinciaDto>> ObtenerProvinciasPaginadasAsync(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // Preparar la consulta con proyección temprana
                var query = _sistemapContext.Provincias
                                    .AsNoTracking();

                // Aplicar el filtro si es necesario
                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(p => p.Nombre.Contains(search));
                }

                // Ejecutar la consulta para contar los registros
                var count = await query.CountAsync();

                // Ejecutar la consulta para obtener los registros paginados
                var items = await query
                                .OrderBy(p => p.Id) // Ordenar por algún criterio si es necesario
                                .Skip((pageIndex - 1) * pageSize)
                                .Take(pageSize)
                                .ProjectTo<ProvinciaDto>(_mapper.ConfigurationProvider)
                                .ToListAsync();

                // Crear y devolver la instancia de Paginate
                return new Paginate<ProvinciaDto>(items, count, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                // Manejar excepciones si es necesario
                _logger.LogError(ex, "Error al obtener provincias paginadas.");
                throw;
            }
        }


        public async Task<List<ProvinciaDto>> ObtenerTodasProvincias()
        {
            return await _sistemapContext
                .Provincias.ProjectTo<ProvinciaDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}