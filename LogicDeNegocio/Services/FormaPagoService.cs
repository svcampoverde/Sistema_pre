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
            var  = _mapper.Map<FormaPago>(request);
            await _sistemapContext.FormaPagos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<FormaPagoDto>();
        }

        // Método para actualizar una FormaPago
        public async Task<FormaPagoDto> ActualizarFormaPago(int id, FormaPagoRequest request)
        {
            var  = await _sistemapContext.FormaPagos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.FormaPagos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<FormaPagoDto>();
        }

        // Método para eliminar una FormaPago
        public async Task EliminarFormaPago(int id)
        {
            var  = await _sistemapContext.FormaPagos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"FormaPago con ID {id} no encontrado.");
            }

            _sistemapContext.FormaPagos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las FormaPagos
        public async Task<List<FormaPagoDto>> ObtenerTodasFormaPagos()
        {
            var s = await _sistemapContext.FormaPagos
                                            .ProjectTo<FormaPagoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
