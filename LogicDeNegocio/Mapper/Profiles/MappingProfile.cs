using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
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
            // Mapeo de UserDto a Persona
            CreateMap<UserDto, Persona>()
                 .IgnoreIfEmpty();


            // Mapeo de UserDto a Usuario
            CreateMap<UserDto, Usuario>()
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Contrasena, opt => opt.MapFrom(src => src.Clave)).IgnoreIfEmpty();

        }
    }
}

