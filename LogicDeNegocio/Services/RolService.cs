using AutoMapper;
using AutoMapper.QueryableExtensions;

using Datos.AplicationDB;
using Datos.Models;

using LogicDeNegocio.Dtos;
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
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;

        public RolService(Func<SistemapContext> dbContextFactory, IMapper mapper)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
        }

        public async Task<RolDto> RegistrarRol(RolRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var rol = _mapper.Map<Rol>(request);
                await context.Roles.AddAsync(rol);
                await context.SaveChangesAsync();
                return _mapper.Map<RolDto>(rol);
            }
        }

        public async Task<RolDto> ActualizarRol(int id, RolRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var rol = await context.Roles.FindAsync(id);
                if (rol == null)
                {
                    throw new KeyNotFoundException($"Rol con ID {id} no encontrado.");
                }

                _mapper.Map(request, rol);
                context.Roles.Update(rol);
                await context.SaveChangesAsync();

                return _mapper.Map<RolDto>(rol);
            }
        }
        public async Task<List<RolDto>> ObtenerRols(string dato)
        {
            using (var context = _dbContextFactory())
            {
                //  consulta inicial para obtener todos los tipos de empresa
                var query = context.Roles.AsQueryable();

                // Si 'filtro' no está vacío, agregamos un filtro adicional a la consulta
                if (!string.IsNullOrEmpty(dato))
                {
                    query = query.Where(te => te.Descripcion.Contains(dato));
                }

                var entidadDto = await query
                                        .ProjectTo<RolDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();

                return entidadDto;
            }
        }
        public async Task EliminarRol(int id)
        {
            using (var context = _dbContextFactory())
            {
                var rol = await context.Roles.FindAsync(id);
                if (rol == null)
                {
                    throw new KeyNotFoundException($"Rol con ID {id} no encontrado.");
                }

                context.Roles.Remove(rol);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Paginate<RolDto>> GetRolesPaginados(string search = null, int pageIndex = 1, int pageSize = 10)
        {
            using (var context = _dbContextFactory())
            {
                try
                {
                    var query = context.Roles.AsNoTracking();

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
        }

        public async Task<List<RolDto>> ObtenerTodosLosRoles()
        {
            using (var context = _dbContextFactory())
            {
                try
                {
                    var roles = await context.Roles
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
        }

        public int GetTotalRoles()
        {
            using (var context = _dbContextFactory())
            {
                return context.Roles.Count();
            }
        }
    }
}
