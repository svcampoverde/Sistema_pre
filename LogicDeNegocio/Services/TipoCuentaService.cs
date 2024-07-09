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
            var entidad = _mapper.Map<TipoCuenta>(request);
            await _sistemapContext.TipoCuentas.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoCuentaDto>(entidad);
        }

        // Método para actualizar una TipoCuenta
        public async Task<TipoCuentaDto> ActualizarTipoCuenta(int id, TipoCuentaRequest request)
        {
            var entidad = await _sistemapContext.TipoCuentas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.TipoCuentas.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoCuentaDto>(entidad);
        }

        // Método para eliminar una TipoCuenta
        public async Task EliminarTipoCuenta(int id)
        {
            var entidad = await _sistemapContext.TipoCuentas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoCuenta con ID {id} no encontrado.");
            }

            _sistemapContext.TipoCuentas.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoCuentas
        public async Task<List<TipoCuentaDto>> ObtenerTodasTipoCuentas()
        {
            var entidadDto = await _sistemapContext.TipoCuentas
                                            .ProjectTo<TipoCuentaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}