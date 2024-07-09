using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class InventarioProfile : Profile
    {
        public InventarioProfile()
        {
            CreateMap<Inventario, InventarioDto>().IgnoreIfEmpty();
            CreateMap<Inventario, InventarioRequest>().IgnoreIfEmpty();
            CreateMap<InventarioRequest, InventarioDto>().IgnoreIfEmpty();
        }
    }
}
