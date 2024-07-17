using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDto>()
                .ForMember(dest => dest.NombreCategoria,
                opt => opt.MapFrom(src => src.CategoriaProducto.Descripcion))
                .ForMember(dest => dest.TipoProducto,
                opt => opt.MapFrom(src => src.TipoProducto.Descripcion))
                .IgnoreIfEmpty();
            CreateMap<Producto, ProductoRequest>().IgnoreIfEmpty();
            CreateMap<ProductoRequest, ProductoDto>().IgnoreIfEmpty();
        }
    }
}
