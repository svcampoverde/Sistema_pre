using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class BancoProfile : Profile
    {
        public BancoProfile()
        {
            CreateMap<Banco, BancoDto>().IgnoreIfEmpty();
            CreateMap<Banco, BancoRequest>().IgnoreIfEmpty();
            CreateMap<BancoRequest, BancoDto>().IgnoreIfEmpty();
        }
    }
}
