using System.Collections.Generic;
using System.Threading.Tasks;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Interfaces
{
    public interface IBaseEntityService
    {
        Task<BaseEntityDto> RegistrarBaseEntity(BaseEntityRequest request);
        Task<BaseEntityDto> ActualizarBaseEntity(int id, BaseEntityRequest request);
        Task EliminarBaseEntity(int id);
        Task<List<BaseEntityDto>> ObtenerTodasBaseEntitys();
    }
}
