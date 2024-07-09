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
    internal class BaseEntityService : IBaseEntityService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public BaseEntityService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una BaseEntity
        public async Task<BaseEntityDto> RegistrarBaseEntity(BaseEntityRequest request)
        {
            var  = _mapper.Map<BaseEntity>(request);
            await _sistemapContext.BaseEntitys.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<BaseEntityDto>();
        }

        // Método para actualizar una BaseEntity
        public async Task<BaseEntityDto> ActualizarBaseEntity(int id, BaseEntityRequest request)
        {
            var  = await _sistemapContext.BaseEntitys.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"BaseEntity con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.BaseEntitys.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<BaseEntityDto>();
        }

        // Método para eliminar una BaseEntity
        public async Task EliminarBaseEntity(int id)
        {
            var  = await _sistemapContext.BaseEntitys.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"BaseEntity con ID {id} no encontrado.");
            }

            _sistemapContext.BaseEntitys.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las BaseEntitys
        public async Task<List<BaseEntityDto>> ObtenerTodasBaseEntitys()
        {
            var s = await _sistemapContext.BaseEntitys
                                            .ProjectTo<BaseEntityDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
