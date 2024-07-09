using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteDto>().IgnoreIfEmpty();
            CreateMap<Cliente, ClienteRequest>().IgnoreIfEmpty();
            CreateMap<ClienteRequest, ClienteDto>().IgnoreIfEmpty();
        }
    }
}
