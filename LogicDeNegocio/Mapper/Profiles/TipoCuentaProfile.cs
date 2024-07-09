using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class TipoCuentaProfile : Profile
    {
        public TipoCuentaProfile()
        {
            CreateMap<TipoCuenta, TipoCuentaDto>().IgnoreIfEmpty();
            CreateMap<TipoCuenta, TipoCuentaRequest>().IgnoreIfEmpty();
            CreateMap<TipoCuentaRequest, TipoCuentaDto>().IgnoreIfEmpty();
        }
    }
}
