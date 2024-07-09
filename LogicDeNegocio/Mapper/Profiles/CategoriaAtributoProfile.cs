using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class CategoriaAtributoProfile : Profile
    {
        public CategoriaAtributoProfile()
        {
            CreateMap<CategoriaAtributo, CategoriaAtributoDto>().IgnoreIfEmpty();
            CreateMap<CategoriaAtributo, CategoriaAtributoRequest>().IgnoreIfEmpty();
            CreateMap<CategoriaAtributoRequest, CategoriaAtributoDto>().IgnoreIfEmpty();
        }
    }
}
