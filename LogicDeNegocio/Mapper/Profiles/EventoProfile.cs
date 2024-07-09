using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class EventoProfile : Profile
    {
        public EventoProfile()
        {
            CreateMap<Evento, EventoDto>().IgnoreIfEmpty();
            CreateMap<Evento, EventoRequest>().IgnoreIfEmpty();
            CreateMap<EventoRequest, EventoDto>().IgnoreIfEmpty();
        }
    }
}
