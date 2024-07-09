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
    internal class TipoEmpresaService : ITipoEmpresaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public TipoEmpresaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una TipoEmpresa
        public async Task<TipoEmpresaDto> RegistrarTipoEmpresa(TipoEmpresaRequest request)
        {
            var  = _mapper.Map<TipoEmpresa>(request);
            await _sistemapContext.TipoEmpresas.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoEmpresaDto>();
        }

        // Método para actualizar una TipoEmpresa
        public async Task<TipoEmpresaDto> ActualizarTipoEmpresa(int id, TipoEmpresaRequest request)
        {
            var  = await _sistemapContext.TipoEmpresas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.TipoEmpresas.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoEmpresaDto>();
        }

        // Método para eliminar una TipoEmpresa
        public async Task EliminarTipoEmpresa(int id)
        {
            var  = await _sistemapContext.TipoEmpresas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
            }

            _sistemapContext.TipoEmpresas.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoEmpresas
        public async Task<List<TipoEmpresaDto>> ObtenerTodasTipoEmpresas()
        {
            var s = await _sistemapContext.TipoEmpresas
                                            .ProjectTo<TipoEmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
