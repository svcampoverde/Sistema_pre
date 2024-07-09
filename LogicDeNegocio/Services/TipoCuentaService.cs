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
    internal class TipoCuentaService : ITipoCuentaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public TipoCuentaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una TipoCuenta
        public async Task<TipoCuentaDto> RegistrarTipoCuenta(TipoCuentaRequest request)
        {
            var  = _mapper.Map<TipoCuenta>(request);
            await _sistemapContext.TipoCuentas.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoCuentaDto>();
        }

        // Método para actualizar una TipoCuenta
        public async Task<TipoCuentaDto> ActualizarTipoCuenta(int id, TipoCuentaRequest request)
        {
            var  = await _sistemapContext.TipoCuentas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.TipoCuentas.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoCuentaDto>();
        }

        // Método para eliminar una TipoCuenta
        public async Task EliminarTipoCuenta(int id)
        {
            var  = await _sistemapContext.TipoCuentas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
            }

            _sistemapContext.TipoCuentas.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoCuentas
        public async Task<List<TipoCuentaDto>> ObtenerTodasTipoCuentas()
        {
            var s = await _sistemapContext.TipoCuentas
                                            .ProjectTo<TipoCuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
