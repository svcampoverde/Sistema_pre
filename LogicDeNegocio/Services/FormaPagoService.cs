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
    internal class FormaPagoService : IFormaPagoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public FormaPagoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una FormaPago
        public async Task<FormaPagoDto> RegistrarFormaPago(FormaPagoRequest request)
        {
            var entidad = _mapper.Map<FormaPago>(request);
            await _sistemapContext.FormaPagos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<FormaPagoDto>(entidad);
        }

        // Método para actualizar una FormaPago
        public async Task<FormaPagoDto> ActualizarFormaPago(int id, FormaPagoRequest request)
        {
            var entidad = await _sistemapContext.FormaPagos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.FormaPagos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<FormaPagoDto>(entidad);
        }

        // Método para eliminar una FormaPago
        public async Task EliminarFormaPago(int id)
        {
            var entidad = await _sistemapContext.FormaPagos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
            }

            _sistemapContext.FormaPagos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las FormaPagos
        public async Task<List<FormaPagoDto>> ObtenerTodasFormaPagos()
        {
            var entidadDto = await _sistemapContext.FormaPagos
                                            .ProjectTo<FormaPagoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}