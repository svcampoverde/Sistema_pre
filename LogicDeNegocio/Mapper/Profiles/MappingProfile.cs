using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Mapper.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeo de UsuarioRequest a PersonaNavegation
            CreateMap<UsuarioRequest, Persona>()
                 .IgnoreIfEmpty();


            // Mapeo de UsuarioRequest a NombreUsuario
            CreateMap<UsuarioRequest, Usuario>()
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario)) .IgnoreIfEmpty();

        }
    }
}

