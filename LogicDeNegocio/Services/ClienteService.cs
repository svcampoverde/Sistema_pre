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
            var  = _mapper.Map<Cliente>(request);
            await _sistemapContext.Clientes.AddAsync();
            await _sistemapContext.SaveChangesAsync();
            return _mapper.Map<ClienteDto>();
        }

        // Método para actualizar una Cliente
        public async Task<ClienteDto> ActualizarCliente(int id, ClienteRequest request)
        {
            var  = await _sistemapContext.Clientes.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
            }

            _mapper.Map(request, );
            _sistemapContext.Clientes.Update();
            await _sistemapContext.SaveChangesAsync();

            return _mapper.Map<ClienteDto>();
        }

        // Método para eliminar una Cliente
        public async Task EliminarCliente(int id)
        {
            var  = await _sistemapContext.Clientes.FindAsync(id);
            if ( == null)
            {
                throw new KeyNotFoundException($"Cliente con ID {id} no encontrado.");
            }

            _sistemapContext.Clientes.Remove();
            await _sistemapContext.SaveChangesAsync();
        }

        // Método para obtener todas las Clientes
        public async Task<List<ClienteDto>> ObtenerTodasClientes()
        {
            var s = await _sistemapContext.Clientes
                                            .ProjectTo<ClienteDto>(_mapper.ConfigurationProvider)
                                            .ToListAsync();
            return s;
        }
    }
}
