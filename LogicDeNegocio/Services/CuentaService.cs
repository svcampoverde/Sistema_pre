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
    internal class CuentaService : ICuentaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public CuentaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Cuentas
        public async Task<CuentaDto> RegistrarCuenta(CuentaRequest request)
        {
            var entidad = _mapper.Map<Cuenta>(request);
            await _sistemapContext.Cuentas.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CuentaDto>(entidad);
        }

        // Método para actualizar una Cuentas
        public async Task<CuentaDto> ActualizarCuenta(int id, CuentaRequest request)
        {
            var entidad = await _sistemapContext.Cuentas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Cuentas con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Cuentas.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CuentaDto>(entidad);
        }

        // Método para eliminar una Cuentas
        public async Task EliminarCuenta(int id)
        {
            var entidad = await _sistemapContext.Cuentas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Cuentas con ID {id} no encontrado.");
            }

            _sistemapContext.Cuentas.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Cuentas
        public async Task<List<CuentaDto>> ObtenerTodasCuentas()
        {
            var entidadDto = await _sistemapContext.Cuentas
                                            .ProjectTo<CuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}