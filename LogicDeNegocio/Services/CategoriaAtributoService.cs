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
    internal class CategoriaAtributoService : ICategoriaAtributoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public CategoriaAtributoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una CategoriaAtributo
        public async Task<CategoriaAtributoDto> RegistrarCategoriaAtributo(CategoriaAtributoRequest request)
        {
            var entidad = _mapper.Map<CategoriaAtributo>(request);
            await _sistemapContext.CategoriaAtributos.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CategoriaAtributoDto>(entidad);
        }

        // Método para actualizar una CategoriaAtributo
        public async Task<CategoriaAtributoDto> ActualizarCategoriaAtributo(int id, CategoriaAtributoRequest request)
        {
            var entidad = await _sistemapContext.CategoriaAtributos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.CategoriaAtributos.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CategoriaAtributoDto>(entidad);
        }

        // Método para eliminar una CategoriaAtributo
        public async Task EliminarCategoriaAtributo(int id)
        {
            var entidad = await _sistemapContext.CategoriaAtributos.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
            }

            _sistemapContext.CategoriaAtributos.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las CategoriaAtributos
        public async Task<List<CategoriaAtributoDto>> ObtenerTodasCategoriaAtributos()
        {
            var entidadDto = await _sistemapContext.CategoriaAtributos
                                            .ProjectTo<CategoriaAtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}