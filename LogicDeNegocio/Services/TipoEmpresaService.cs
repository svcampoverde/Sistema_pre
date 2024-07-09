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
            var entidad = _mapper.Map<TipoEmpresa>(request);
            await _sistemapContext.TipoEmpresas.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<TipoEmpresaDto>(entidad);
        }

        // Método para actualizar una TipoEmpresa
        public async Task<TipoEmpresaDto> ActualizarTipoEmpresa(int id, TipoEmpresaRequest request)
        {
            var entidad = await _sistemapContext.TipoEmpresas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.TipoEmpresas.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<TipoEmpresaDto>(entidad);
        }

        // Método para eliminar una TipoEmpresa
        public async Task EliminarTipoEmpresa(int id)
        {
            var entidad = await _sistemapContext.TipoEmpresas.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"TipoEmpresa con ID {id} no encontrado.");
            }

            _sistemapContext.TipoEmpresas.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las TipoEmpresas
        public async Task<List<TipoEmpresaDto>> ObtenerTodasTipoEmpresas()
        {
            var entidadDto = await _sistemapContext.TipoEmpresas
                                            .ProjectTo<TipoEmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}