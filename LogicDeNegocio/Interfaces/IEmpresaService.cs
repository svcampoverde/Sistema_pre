using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IEmpresaService
    {
        Task<EmpresaDto> RegistrarEmpresa(EmpresaRequest request);
        Task<EmpresaDto> ActualizarEmpresa(int id, EmpresaRequest request);
        Task EliminarEmpresa(int id);
        Task<List<EmpresaDto>> ObtenerTodasEmpresas();
    }
}
