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
    internal class EmpresaService : IEmpresaService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public EmpresaService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Empresa
        public async Task<EmpresaDto> RegistrarEmpresa(EmpresaRequest request)
        {
            var  = _mapper.Map<Empresa>(request);
            await _sistemapContext.Empresas.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EmpresaDto>();
        }

        // Método para actualizar una Empresa
        public async Task<EmpresaDto> ActualizarEmpresa(int id, EmpresaRequest request)
        {
            var  = await _sistemapContext.Empresas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Empresas.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EmpresaDto>();
        }

        // Método para eliminar una Empresa
        public async Task EliminarEmpresa(int id)
        {
            var  = await _sistemapContext.Empresas.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
            }

            _sistemapContext.Empresas.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Empresas
        public async Task<List<EmpresaDto>> ObtenerTodasEmpresas()
        {
            var s = await _sistemapContext.Empresas
                                            .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
