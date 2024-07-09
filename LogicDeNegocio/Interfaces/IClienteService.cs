using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto> RegistrarCliente(ClienteRequest request);
        Task<ClienteDto> ActualizarCliente(int id, ClienteRequest request);
        Task EliminarCliente(int id);
        Task<List<ClienteDto>> ObtenerTodasClientes();
    }
}
