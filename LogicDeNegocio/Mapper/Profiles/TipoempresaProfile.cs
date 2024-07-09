using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class TipoempresaProfile : Profile
    {
        public TipoempresaProfile()
        {
            CreateMap<TipoEmpresa, TipoEmpresaDto>().IgnoreIfEmpty();
            CreateMap<TipoEmpresa, TipoEmpresaRequest>().IgnoreIfEmpty();
            CreateMap<TipoEmpresaRequest, TipoEmpresaDto>().IgnoreIfEmpty();
        }
    }
}
