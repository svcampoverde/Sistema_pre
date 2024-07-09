using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class AtributoProfile : Profile
    {
        public AtributoProfile()
        {
            CreateMap<Atributo, AtributoDto>().IgnoreIfEmpty();
            CreateMap<Atributo, AtributoRequest>().IgnoreIfEmpty();
            CreateMap<AtributoRequest, AtributoDto>().IgnoreIfEmpty();
        }
    }
}
