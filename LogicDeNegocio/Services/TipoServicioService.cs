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
            var  = _mapper.Map<TipoServicio>(request);
            await _sistemapContext.TipoServicios.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoServicioDto>();
        }

        // Método para actualizar una TipoServicio
        public async Task<TipoServicioDto> ActualizarTipoServicio(int id, TipoServicioRequest request)
        {
            var  = await _sistemapContext.TipoServicios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.TipoServicios.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoServicioDto>();
        }

        // Método para eliminar una TipoServicio
        public async Task EliminarTipoServicio(int id)
        {
            var  = await _sistemapContext.TipoServicios.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoServicio con ID {id} no encontrado.");
            }

            _sistemapContext.TipoServicios.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoServicios
        public async Task<List<TipoServicioDto>> ObtenerTodasTipoServicios()
        {
            var s = await _sistemapContext.TipoServicios
                                            .ProjectTo<TipoServicioDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
