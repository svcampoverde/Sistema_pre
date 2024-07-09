using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class EmpleadoProfile : Profile
    {
        public EmpleadoProfile()
        {
            CreateMap<Empleado, EmpleadoDto>().IgnoreIfEmpty();
            CreateMap<Empleado, EmpleadoRequest>().IgnoreIfEmpty();
            CreateMap<EmpleadoRequest, EmpleadoDto>().IgnoreIfEmpty();
        }
    }
}
