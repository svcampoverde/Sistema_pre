using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class PresupuestoProfile : Profile
    {
        public PresupuestoProfile()
        {
            CreateMap<Presupuesto, PresupuestoDto>().IgnoreIfEmpty();
            CreateMap<Presupuesto, PresupuestoRequest>().IgnoreIfEmpty();
            CreateMap<PresupuestoRequest, PresupuestoDto>().IgnoreIfEmpty();
        }
    }
}
