using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class PresupuestoDetalleProfile : Profile
    {
        public PresupuestoDetalleProfile()
        {
            CreateMap<PresupuestoDetalle, PresupuestoDetalleDto>().IgnoreIfEmpty();
            CreateMap<PresupuestoDetalle, PresupuestoDetalleRequest>().IgnoreIfEmpty();
            CreateMap<PresupuestoDetalleRequest, PresupuestoDetalleDto>().IgnoreIfEmpty();
        }
    }
}
