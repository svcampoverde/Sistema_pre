using FluentValidation;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Mapper;
using LogicDeNegocio.Services.Validator;
using LogicDeNegocio.Services;
 
using Unity;
using LogicDeNegocio.Personas;
using Microsoft.Extensions.Logging;
using Unity.Lifetime;
namespace LogicDeNegocio.Configuration
{
    public static class LogicDeNegocioConfig
    {
        public static IUnityContainer RegisterTypes(this IUnityContainer container)
        {
            /// Registrar Servicio de Usuarios
            container.RegisterType<IUserService, UserService>();


            // Registrar AutoMapper
            var mapper = AutoMapperConfig.Initialize();
            container.RegisterInstance(mapper);
            // Register FluentValidation validators
            container.RegisterType<IValidator<UserDto>, UsuarioDtoValidator>();
            // Registro de ILogger en Unity
            container.RegisterType<ILoggerFactory, LoggerFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));
            return container;

        }
    }
}
