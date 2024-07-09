using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class CategoriaProductoProfile : Profile
    {
        public CategoriaProductoProfile()
        {
            CreateMap<CategoriaProducto, CategoriaProductoDto>().IgnoreIfEmpty();
            CreateMap<CategoriaProducto, CategoriaProductoRequest>().IgnoreIfEmpty();
            CreateMap<CategoriaProductoRequest, CategoriaProductoDto>().IgnoreIfEmpty();
        }
    }
}
