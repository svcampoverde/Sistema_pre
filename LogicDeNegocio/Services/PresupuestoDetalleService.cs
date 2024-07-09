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
            var  = _mapper.Map<PresupuestoDetalle>(request);
            await _sistemapContext.PresupuestoDetalles.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<PresupuestoDetalleDto>();
        }

        // Método para actualizar una PresupuestoDetalle
        public async Task<PresupuestoDetalleDto> ActualizarPresupuestoDetalle(int id, PresupuestoDetalleRequest request)
        {
            var  = await _sistemapContext.PresupuestoDetalles.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.PresupuestoDetalles.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<PresupuestoDetalleDto>();
        }

        // Método para eliminar una PresupuestoDetalle
        public async Task EliminarPresupuestoDetalle(int id)
        {
            var  = await _sistemapContext.PresupuestoDetalles.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"PresupuestoDetalle con ID {id} no encontrado.");
            }

            _sistemapContext.PresupuestoDetalles.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las PresupuestoDetalles
        public async Task<List<PresupuestoDetalleDto>> ObtenerTodasPresupuestoDetalles()
        {
            var s = await _sistemapContext.PresupuestoDetalles
                                            .ProjectTo<PresupuestoDetalleDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
