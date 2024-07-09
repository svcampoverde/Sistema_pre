using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class ProveedorProfile : Profile
    {
        public ProveedorProfile()
        {
            CreateMap<Proveedor, ProveedorDto>().IgnoreIfEmpty();
            CreateMap<Proveedor, ProveedorRequest>().IgnoreIfEmpty();
            CreateMap<ProveedorRequest, ProveedorDto>().IgnoreIfEmpty();
        }
    }
}
