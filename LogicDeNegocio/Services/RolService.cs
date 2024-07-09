using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    public class RolService : IRolService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public RolService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        public async Task<RolDto> RegistrarRol(RolRequest request)
        {
            var rol = _mapper.Map<Rol>(request);
            await _sistemapContext.Roles.AddAsync(rol);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<RolDto>(rol);
        }

        public async Task<RolDto> ActualizarRol(int id, RolRequest request)
        {
            var rol = await _sistemapContext.Roles.FindAsync(id);
            if (rol == null)
            {
                throw new KeyNotFoundException($"Rol con ID {id} no encontrado.");
            }

            _mapper.Map(request, rol);
            _sistemapContext.Roles.Update(rol);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<RolDto>(rol);
        }

        public async Task EliminarRol(int id)
        {
            var rol = await _sistemapContext.Roles.FindAsync(id);
            if (rol == null)
            {
                throw new KeyNotFoundException($"Rol con ID {id} no encontrado.");
            }

            _sistemapContext.Roles.Remove(rol);
            await _sistemapContext.SaveChangesAsync();
        }

        public async Task<Paginate<RolDto>> GetRolesPaginados(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                var query = _sistemapContext.Roles.AsNoTracking();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x => x.Descripcion.Contains(search) || x.Codigo.Contains(search));
                }

                var count = await query.CountAsync();

                var items = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ProjectTo<RolDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();

                return new Paginate<RolDto>(items, count, pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener roles paginados", ex);
            }
        }

        public async Task<List<RolDto>> ObtenerTodosLosRoles()
        {
            try
            {
                var roles = await _sistemapContext.Roles
                                    .AsNoTracking()
                                    .ProjectTo<RolDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();

                return roles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los roles", ex);
            }
        }

        public int GetTotalRoles()
        {
            return _sistemapContext.Roles.Count();
        }
    }
}
