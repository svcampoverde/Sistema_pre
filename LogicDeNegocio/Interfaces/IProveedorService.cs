using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IProveedorService
    {
        Task<ProveedorDto> RegistrarProveedor(ProveedorRequest request);

        Task<ProveedorDto> ActualizarProveedor(int id, ProveedorRequest request);

        Task EliminarProveedor(int id);

        Task<List<ProveedorDto>> ObtenerTodasProveedors();
    }
}