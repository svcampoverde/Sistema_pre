using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class AtributoService : IAtributoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public AtributoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Atributo
        public async Task<AtributoDto> RegistrarAtributo(AtributoRequest request)
        {
            var entidad = _mapper.Map<Atributo>(request);
            await _sistemapContext.Atributos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<AtributoDto>(entidad);
        }

        // Método para actualizar una Atributo
        public async Task<AtributoDto> ActualizarAtributo(int id, AtributoRequest request)
        {
            var entidad = await _sistemapContext.Atributos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Atributo con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Atributos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<AtributoDto>(entidad);
        }

        // Método para eliminar una Atributo
        public async Task EliminarAtributo(int id)
        {
            var entidad = await _sistemapContext.Atributos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Atributo con ID {id} no encontrado.");
            }

            _sistemapContext.Atributos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Atributos
        public async Task<List<AtributoDto>> ObtenerTodasAtributos()
        {
            var entidadDto = await _sistemapContext.Atributos
                                            .ProjectTo<AtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}