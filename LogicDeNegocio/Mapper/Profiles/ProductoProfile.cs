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
            CreateMap<Producto, ProductoDto>().IgnoreIfEmpty();
            CreateMap<Producto, ProductoRequest>().IgnoreIfEmpty();
            CreateMap<ProductoRequest, ProductoDto>().IgnoreIfEmpty();
        }
    }
}
