using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class TipoServicioService : ITipoServicioService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public TipoServicioService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una TipoServicio
        public async Task<TipoServicioDto> RegistrarTipoServicio(TipoServicioRequest request)
        {
            var entidad = _mapper.Map<TipoServicio>(request);
            await _sistemapContext.TipoServicios.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoServicioDto>(entidad);
        }

        // Método para actualizar una TipoServicio
        public async Task<TipoServicioDto> ActualizarTipoServicio(int id, TipoServicioRequest request)
        {
            var entidad = await _sistemapContext.TipoServicios.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.TipoServicios.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoServicioDto>(entidad);
        }

        // Método para eliminar una TipoServicio
        public async Task EliminarTipoServicio(int id)
        {
            var entidad = await _sistemapContext.TipoServicios.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
            }

            _sistemapContext.TipoServicios.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoServicios
        public async Task<List<TipoServicioDto>> ObtenerTodasTipoServicios()
        {
            var entidadDto = await _sistemapContext.TipoServicios
                                            .ProjectTo<TipoServicioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}