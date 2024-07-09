using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class TipoProductoProfile : Profile
    {
        public TipoProductoProfile()
        {
            CreateMap<TipoProducto, TipoProductoDto>().IgnoreIfEmpty();
            CreateMap<TipoProducto, TipoProductoRequest>().IgnoreIfEmpty();
            CreateMap<TipoProductoRequest, TipoProductoDto>().IgnoreIfEmpty();
        }
    }
}
