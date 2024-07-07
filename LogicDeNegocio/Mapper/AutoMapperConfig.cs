using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace LogicDeNegocio.Mapper
{
    internal class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Obtiene el ensamblado donde están los perfiles
                var profilesAssembly = Assembly.GetExecutingAssembly();

                // Encuentra todas las clases que heredan de Profile
                var profiles = profilesAssembly.GetTypes()
                    .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract);
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });

            return config.CreateMapper();
        }
    }
}
