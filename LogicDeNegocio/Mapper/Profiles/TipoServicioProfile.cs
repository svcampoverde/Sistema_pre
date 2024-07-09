using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class TipoServicioProfile : Profile
    {
        public TipoServicioProfile()
        {
            CreateMap<TipoServicio, TipoServicioDto>().IgnoreIfEmpty();
            CreateMap<TipoServicio, TipoServicioRequest>().IgnoreIfEmpty();
            CreateMap<TipoServicioRequest, TipoServicioDto>().IgnoreIfEmpty();
        }
    }
}
