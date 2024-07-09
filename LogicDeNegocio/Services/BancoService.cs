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
    internal class BancoService : IBancoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public BancoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Banco
        public async Task<BancoDto> RegistrarBanco(BancoRequest request)
        {
            var entidad = _mapper.Map<Banco>(request);
            await _sistemapContext.Bancos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<BancoDto>(entidad);
        }

        // Método para actualizar una Banco
        public async Task<BancoDto> ActualizarBanco(int id, BancoRequest request)
        {
            var entidad = await _sistemapContext.Bancos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Bancos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<BancoDto>(entidad);
        }

        // Método para eliminar una Banco
        public async Task EliminarBanco(int id)
        {
            var entidad = await _sistemapContext.Bancos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
            }

            _sistemapContext.Bancos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Bancos
        public async Task<List<BancoDto>> ObtenerTodasBancos()
        {
            var entidadDto = await _sistemapContext.Bancos
                                            .ProjectTo<BancoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}