using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface IEmpresaService
    {
        Task<EmpresaDto> RegistrarEmpresa(EmpresaRequest request);

        Task<EmpresaDto> ActualizarEmpresa(int id, EmpresaRequest request);

        Task EliminarEmpresa(int id);

        Task<List<EmpresaDto>> ObtenerTodasEmpresas();
        Task<List<EmpresaDto>> ObtenerEmpresas(string emp);
    }
}