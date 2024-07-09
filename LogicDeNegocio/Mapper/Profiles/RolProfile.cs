using AutoMapper;

using Datos.Models;

using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;
 

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class RolProfile : Profile
    {
        public RolProfile()
        {
            CreateMap<Rol, RolDto>().IgnoreIfEmpty();
            CreateMap<Rol, RolRequest>().IgnoreIfEmpty();
            CreateMap<RolRequest, RolDto>().IgnoreIfEmpty();
        }
    }
}