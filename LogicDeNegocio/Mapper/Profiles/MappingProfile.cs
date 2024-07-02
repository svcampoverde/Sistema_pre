using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Mapper.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Mapeo de UserDto a Persona
            CreateMap<UserDto, Persona>()
                .ForMember(dest => dest.Cedula, opt => opt.MapFrom(src => src.Cedula))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Celular, opt => opt.MapFrom(src => src.Celular))
                .ForMember(dest => dest.Correo, opt => opt.MapFrom(src => src.Correo))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.CiudadId, opt => opt.MapFrom(src => src.IdCiudad))

                // Ignorar las colecciones de navegación
                .ForMember(dest => dest.Clientes, opt => opt.Ignore())
                .ForMember(dest => dest.Empleados, opt => opt.Ignore())
                .ForMember(dest => dest.Proveedores, opt => opt.Ignore());


            // Mapeo de UserDto a Usuario
            CreateMap<UserDto, Usuario>()
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Contrasena, opt => opt.MapFrom(src => src.Clave))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.IdRol))
                .ForMember(dest => dest.IdPersona, opt => opt.Ignore()) // Ignorado ya que se establece posteriormente

                // Ignorar las colecciones de navegación
                .ForMember(dest => dest.Persona, opt => opt.Ignore())
                .ForMember(dest => dest.Rol, opt => opt.Ignore());

        }
    }
    }

