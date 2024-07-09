using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class CuentaProfile : Profile
    {
        public CuentaProfile()
        {
            CreateMap<Cuenta, CuentaDto>().IgnoreIfEmpty();
            CreateMap<Cuenta, CuentaRequest>().IgnoreIfEmpty();
            CreateMap<CuentaRequest, CuentaDto>().IgnoreIfEmpty();
        }
    }
}
