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
    internal class ClienteService : IClienteService
    {
        private readonly Func<SistemapContext> _dbContextFactory;
        private readonly IMapper _mapper;
        private readonly ILogger<ClienteService> _logger;

        public ClienteService(Func<SistemapContext> dbContextFactory, IMapper mapper, ILogger<ClienteService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ClienteDto> RegistrarCliente(ClienteRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = _mapper.Map<Cliente>(request);
                await context.Clientes.AddAsync(entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ClienteDto>(entidad);
            }
        }

        public async Task<ClienteDto> ActualizarCliente(int id, ClienteRequest request)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Clientes.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Cliente no encontrada.");
                    throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
                }

                _mapper.Map(request, entidad);
                await context.SaveChangesAsync();
                return _mapper.Map<ClienteDto>(entidad);
            }
        }

        public async Task EliminarCliente(int id)
        {
            using (var context = _dbContextFactory())
            {
                var entidad = await context.Clientes.FindAsync(id);
                if (entidad == null)
                {
                    _logger.LogWarning("Cliente no encontrada.");
                    throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
                }

                context.Clientes.Remove(entidad);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ClienteDto>> ObtenerTodasClientes()
        {
            using (var context = _dbContextFactory())
            {
                var entidadDto = await context.Clientes
                                            .ProjectTo<ClienteDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
                return entidadDto;
            }
        }
    }
}
