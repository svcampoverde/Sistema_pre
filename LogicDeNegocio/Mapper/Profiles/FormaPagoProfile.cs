using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class FormaPagoProfile : Profile
    {
        public FormaPagoProfile()
        {
            CreateMap<FormaPago, FormaPagoDto>().IgnoreIfEmpty();
            CreateMap<FormaPago, FormaPagoRequest>().IgnoreIfEmpty();
            CreateMap<FormaPagoRequest, FormaPagoDto>().IgnoreIfEmpty();
        }
    }
}
