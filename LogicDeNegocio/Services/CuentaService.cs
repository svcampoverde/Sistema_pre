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
    internal class CuentaService : ICuentaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public CuentaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Cuenta
        public async Task<CuentaDto> RegistrarCuenta(CuentaRequest request)
        {
            var  = _mapper.Map<Cuenta>(request);
            await _sistemapContext.Cuentas.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CuentaDto>();
        }

        // Método para actualizar una Cuenta
        public async Task<CuentaDto> ActualizarCuenta(int id, CuentaRequest request)
        {
            var  = await _sistemapContext.Cuentas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Cuenta con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Cuentas.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CuentaDto>();
        }

        // Método para eliminar una Cuenta
        public async Task EliminarCuenta(int id)
        {
            var  = await _sistemapContext.Cuentas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Cuenta con ID {id} no encontrado.");
            }

            _sistemapContext.Cuentas.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Cuentas
        public async Task<List<CuentaDto>> ObtenerTodasCuentas()
        {
            var s = await _sistemapContext.Cuentas
                                            .ProjectTo<CuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
