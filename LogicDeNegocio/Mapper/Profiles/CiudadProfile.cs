using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class CiudadProfile : Profile
    {
        public CiudadProfile()
        {
            CreateMap<Ciudad, CiudadDto>().IgnoreIfEmpty();
            CreateMap<Ciudad, CiudadRequest>().IgnoreIfEmpty();
            CreateMap<CiudadRequest, CiudadDto>().IgnoreIfEmpty();
        }
    }
}
