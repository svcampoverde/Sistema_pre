using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class AtributoProductoProfile : Profile
    {
        public AtributoProductoProfile()
        {
            CreateMap<AtributoProducto, AtributoProductoDto>().IgnoreIfEmpty();
            CreateMap<AtributoProducto, AtributoProductoRequest>().IgnoreIfEmpty();
            CreateMap<AtributoProductoRequest, AtributoProductoDto>().IgnoreIfEmpty();
        }
    }
}
