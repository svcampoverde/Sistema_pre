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
            var  = _mapper.Map<Banco>(request);
            await _sistemapContext.Bancos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<BancoDto>();
        }

        // Método para actualizar una Banco
        public async Task<BancoDto> ActualizarBanco(int id, BancoRequest request)
        {
            var  = await _sistemapContext.Bancos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Bancos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<BancoDto>();
        }

        // Método para eliminar una Banco
        public async Task EliminarBanco(int id)
        {
            var  = await _sistemapContext.Bancos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Banco con ID {id} no encontrado.");
            }

            _sistemapContext.Bancos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Bancos
        public async Task<List<BancoDto>> ObtenerTodasBancos()
        {
            var s = await _sistemapContext.Bancos
                                            .ProjectTo<BancoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
