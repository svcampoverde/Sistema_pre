using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoEmpresaService
    {
        Task<TipoEmpresaDto> RegistrarTipoEmpresa(TipoEmpresaRequest request);
        Task<TipoEmpresaDto> ActualizarTipoEmpresa(int id, TipoEmpresaRequest request);
        Task EliminarTipoEmpresa(int id);
        Task<List<TipoEmpresaDto>> ObtenerTodasTipoEmpresas();
    }
}
