using AutoMapper;
using LogicDeNegocio.Mapper.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.Mapper
{
    internal class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
                // Agrega más perfiles si es necesario
            });
            return config.CreateMapper();
        }
    }
}
