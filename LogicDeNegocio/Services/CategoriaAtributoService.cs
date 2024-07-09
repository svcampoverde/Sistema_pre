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
            var  = _mapper.Map<CategoriaAtributo>(request);
            await _sistemapContext.CategoriaAtributos.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<CategoriaAtributoDto>();
        }

        // Método para actualizar una CategoriaAtributo
        public async Task<CategoriaAtributoDto> ActualizarCategoriaAtributo(int id, CategoriaAtributoRequest request)
        {
            var  = await _sistemapContext.CategoriaAtributos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.CategoriaAtributos.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<CategoriaAtributoDto>();
        }

        // Método para eliminar una CategoriaAtributo
        public async Task EliminarCategoriaAtributo(int id)
        {
            var  = await _sistemapContext.CategoriaAtributos.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"CategoriaAtributo con ID {id} no encontrado.");
            }

            _sistemapContext.CategoriaAtributos.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las CategoriaAtributos
        public async Task<List<CategoriaAtributoDto>> ObtenerTodasCategoriaAtributos()
        {
            var s = await _sistemapContext.CategoriaAtributos
                                            .ProjectTo<CategoriaAtributoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
