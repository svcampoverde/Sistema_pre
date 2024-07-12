using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDto>().IgnoreIfEmpty();
            CreateMap<Usuario, UsuarioRequest>().IgnoreIfEmpty();
            CreateMap<UsuarioRequest, UsuarioDto>().IgnoreIfEmpty();
            CreateMap<Persona, UsuarioDto>().IgnoreIfEmpty();
            CreateMap<Persona, UsuarioRequest>().IgnoreIfEmpty();
        }
    }
}
