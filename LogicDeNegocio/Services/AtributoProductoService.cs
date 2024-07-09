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
    internal class AtributoProductoService : IAtributoProductoService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public AtributoProductoService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una AtributoProducto
        public async Task<AtributoProductoDto> RegistrarAtributoProducto(AtributoProductoRequest request)
        {
            var atributoProducto = _mapper.Map<AtributoProducto>(request);
            await _sistemapContext.AtributoProductos.AddAsync(atributoProducto);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<AtributoProductoDto>(atributoProducto);
        }

        // Método para actualizar una AtributoProducto
        public async Task<AtributoProductoDto> ActualizarAtributoProducto(int id, AtributoProductoRequest request)
        {
            var atributoProducto = await _sistemapContext.AtributoProductos.FindAsync(id);
            if (atributoProducto == null)
            {
                throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
            }

            atributoProducto = _mapper.Map(request, atributoProducto);
            _sistemapContext.AtributoProductos.Update(atributoProducto);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<AtributoProductoDto>(atributoProducto);
        }

        // Método para eliminar una AtributoProducto
        public async Task EliminarAtributoProducto(int id)
        {
            var tributoProducto = await _sistemapContext.AtributoProductos.FindAsync(id);
            if (tributoProducto == null)
            {
                throw new KeyNotFoundException($"AtributoProducto con ID {id} no encontrado.");
            }

            _sistemapContext.AtributoProductos.Remove(tributoProducto);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las AtributoProductos
        public async Task<List<AtributoProductoDto>> ObtenerTodasAtributoProductos()
        {
            var s = await _sistemapContext.AtributoProductos
                                            .ProjectTo<AtributoProductoDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}