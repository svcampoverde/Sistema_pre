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
    internal class ClienteService : IClienteService
    {
        private readonly SistemapContext _sistemapContext;
        private readonly IMapper _mapper;

        public ClienteService(SistemapContext sistemapContext, IMapper mapper)
        {
            _sistemapContext = sistemapContext;
            _mapper = mapper;
        }

        // Método para registrar una Cliente
        public async Task<ClienteDto> RegistrarCliente(ClienteRequest request)
        {
            var entidad = _mapper.Map<Cliente>(request);
            await _sistemapContext.Clientes.AddAsync(entidad);
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ClienteDto>(entidad);
        }

        // Método para actualizar una Cliente
        public async Task<ClienteDto> ActualizarCliente(int id, ClienteRequest request)
        {
            var entidad = await _sistemapContext.Clientes.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
            }

            entidad = _mapper.Map(request, entidad);
            _sistemapContext.Clientes.Update(entidad);
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ClienteDto>(entidad);
        }

        // Método para eliminar una Cliente
        public async Task EliminarCliente(int id)
        {
            var entidad = await _sistemapContext.Clientes.FindAsync(id);
            if (entidad == null)
            {
                throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
            }

            _sistemapContext.Clientes.Remove(entidad);
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Clientes
        public async Task<List<ClienteDto>> ObtenerTodasClientes()
        {
            var entidadDto = await _sistemapContext.Clientes
                                            .ProjectTo<ClienteDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return entidadDto;
        }
    }
}