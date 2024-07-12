using AutoMapper;
using AutoMapper.QueryableExtensions;
using Datos.AplicationDB;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicDeNegocio.Services
{
    internal class EmpresaService : IEmpresaService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<EmpresaService> _logger;

        public EmpresaService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<EmpresaService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<EmpresaDto> RegistrarEmpresa(EmpresaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Empresa>(request);
                await context.Empresas.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EmpresaDto>(entidad);
            }
        }

        public async Task<EmpresaDto> ActualizarEmpresa(int id, EmpresaRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Empresas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Empresa no encontrada.");
                    throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<EmpresaDto>(entidad);
            }
        }

        public async Task EliminarEmpresa(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Empresas.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Empresa no encontrada.");
                    throw new KeyNotFoundException($"Empresa con ID {id} no encontrado.");
                }
                //entidad.Activo = false;
                //context.Empresas.Update(entidad);

                context.Empresas.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<EmpresaDto>> ObtenerEmpresas(string emp)
        {
            using (var context = _dbContextFactory())
            {
                var query = from e in context.Empresas
                            join tpem in context.TipoEmpresas on e.IdTipoEmpresa equals tpem.Id
                            where e.Activo == true// && (string.IsNullOrEmpty(emp) || e.Descripcion.Contains(emp))
                            select new
                            {
                                e.Id,
                                e.Descripcion,
                                e.Telefono,
                                e.Correo,
                                e.Direccion,
                                TipoEmpresaDescripcion = tpem.Descripcion
                            };
                if (!string.IsNullOrEmpty(emp))
                {
                    query = query.Where(e => e.Descripcion.Contains(emp));
                }
                var datos = await query.ToListAsync();
                return datos.Select(d => new EmpresaDto
                {
                    Id = d.Id,
                    Descripcion = d.Descripcion,
                    Telefono = d.Telefono,
                    Correo = d.Correo,
                    Direccion = d.Direccion,
                    TipoEmpresaDescripcion = d.TipoEmpresaDescripcion
                }).ToList();

            }
        }

        public async Task<List<EmpresaDto>> ObtenerTodasEmpresas()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Empresas
                                            .ProjectTo<EmpresaDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
