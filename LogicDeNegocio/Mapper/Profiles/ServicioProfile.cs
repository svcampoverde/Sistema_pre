using AutoMapper;
using Datos.Models;
using LogicDeNegocio.Dtos;using LogicDeNegocio.Requests;
using LogicDeNegocio.Extensions;
using LogicDeNegocio.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Mapper.Profiles
{
    public class ServicioProfile: Profile
    {
        public ServicioProfile() {

            CreateMap<Servicio,ServicioDto>()
                .ForMember(dest => dest.TipoServicio,
                opt => opt.MapFrom(src => src.TipoServicio.Descripcion)).IgnoreIfEmpty();
            CreateMap<Servicio, ServicioRequest>().IgnoreIfEmpty();

        }
    }
}
