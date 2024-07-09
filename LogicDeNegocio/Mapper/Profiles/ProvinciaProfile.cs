using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class ProvinciaProfile : Profile
    {
        public ProvinciaProfile()
        {
            CreateMap<Provincia, ProvinciaDto>().IgnoreIfEmpty();
            CreateMap<Provincia, ProvinciaRequest>().IgnoreIfEmpty();
            CreateMap<ProvinciaRequest, ProvinciaDto>().IgnoreIfEmpty();
        }
    }
}
