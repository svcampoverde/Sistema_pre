using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicDeNegocio.Interfaces
{
    public interface ITipoEmpresaService
    {
        Task<TipoEmpresaDto> RegistrarTipoEmpresa(TipoEmpresaRequest request);

        Task<TipoEmpresaDto> ActualizarTipoEmpresa(int id, TipoEmpresaRequest request);

        Task EliminarTipoEmpresa(int id);

        Task<List<TipoEmpresaDto>> ObtenerTodasTipoEmpresas();
        Task<List<TipoEmpresaDto>> ObtenerTipoEmpresas(string dato);
    }
}