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
    internal class PresupuestoDetalleService : IPresupuestoDetalleService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public PresupuestoDetalleService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una PresupuestoDetalle
        public async Task<PresupuestoDetalleDto> RegistrarPresupuestoDetalle(PresupuestoDetalleRequest request)
        {
            var entidad = _mapper.Map<PresupuestoDetalle>(request);
            await _sistemapContext.PresupuestoDetalles.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<PresupuestoDetalleDto>(entidad);
        }

        // Método para actualizar una PresupuestoDetalle
        public async Task<PresupuestoDetalleDto> ActualizarPresupuestoDetalle(int id, PresupuestoDetalleRequest request)
        {
            var entidad = await _sistemapContext.PresupuestoDetalles.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.PresupuestoDetalles.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<PresupuestoDetalleDto>(entidad);
        }

        // Método para eliminar una PresupuestoDetalle
        public async Task EliminarPresupuestoDetalle(int id)
        {
            var entidad = await _sistemapContext.PresupuestoDetalles.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
            }

            _sistemapContext.PresupuestoDetalles.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las PresupuestoDetalles
        public async Task<List<PresupuestoDetalleDto>> ObtenerTodasPresupuestoDetalles()
        {
            var entidadDto = await _sistemapContext.PresupuestoDetalles
                                            .ProjectTo<PresupuestoDetalleDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}