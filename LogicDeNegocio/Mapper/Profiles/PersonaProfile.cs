using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Mapper.Profiles
{
    internal class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<Persona, PersonaDto>().IgnoreIfEmpty();
            CreateMap<Persona, PersonaRequest>().IgnoreIfEmpty();
            CreateMap<PersonaRequest, PersonaDto>().IgnoreIfEmpty();
        }
    }
}
