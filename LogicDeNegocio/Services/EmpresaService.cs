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
            var entidad = _mapper.Map<Empresa>(request);
            await _sistemapContext.Empresas.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<EmpresaDto>(entidad);
        }

        // Método para actualizar una Empresa
        public async Task<EmpresaDto> ActualizarEmpresa(int id, EmpresaRequest request)
        {
            var entidad = await _sistemapContext.Empresas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Empresas.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<EmpresaDto>(entidad);
        }

        // Método para eliminar una Empresa
        public async Task EliminarEmpresa(int id)
        {
            var entidad = await _sistemapContext.Empresas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
            }

            _sistemapContext.Empresas.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Empresas
        public async Task<List<EmpresaDto>> ObtenerTodasEmpresas()
        {
            var entidadDto = await _sistemapContext.Empresas
                                            .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}