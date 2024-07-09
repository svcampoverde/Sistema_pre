using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<Empresa, EmpresaDto>().IgnoreIfEmpty();
            CreateMap<Empresa, EmpresaRequest>().IgnoreIfEmpty();
            CreateMap<EmpresaRequest, EmpresaDto>().IgnoreIfEmpty();
        }
    }
}
