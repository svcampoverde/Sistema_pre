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
    internal class PresupuestoService : IPresupuestoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public PresupuestoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar un Presupuesto
        public async Task<PresupuestoDto> RegistrarPresupuesto(PresupuestoRequest request)
        {
            var presupuesto = _mapper.Map<Presupuesto>(request);
            await _sistemapContext.Presupuestos.AddAsync(presupuesto);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<PresupuestoDto>(presupuesto);
        }

        // Método para actualizar un Presupuesto
        public async Task<PresupuestoDto> ActualizarPresupuesto(int id, PresupuestoRequest request)
        {
            var presupuesto = await _sistemapContext.Presupuestos.FindAsync(id);
            if (presupuesto == null)
            {
                throw new KeyNotFoundException($"Presupuesto con ID {id} no encontrado.");
            }

            _mapper.Map(request, presupuesto);
            _sistemapContext.Presupuestos.Update(presupuesto);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<PresupuestoDto>(presupuesto);
        }

        // Método para eliminar un Presupuesto
        public async Task EliminarPresupuesto(int id)
        {
            var presupuesto = await _sistemapContext.Presupuestos.FindAsync(id);
            if (presupuesto == null)
            {
                throw new KeyNotFoundException($"Presupuesto con ID {id} no encontrado.");
            }

            _sistemapContext.Presupuestos.Remove(presupuesto);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Presupuestos
        public async Task<List<PresupuestoDto>> ObtenerTodasPresupuestos()
        {
            var presupuestos = await _sistemapContext.Presupuestos
                                            .ProjectTo<PresupuestoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return presupuestos;
        }
    }
}