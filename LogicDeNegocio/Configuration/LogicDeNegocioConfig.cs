using FluentValidation;
using LogicDeNegocio.Dtos;
using LogicDeNegocio.Requests;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Mapper;
using LogicDeNegocio.Services.Validator;
using LogicDeNegocio.Services;

using Unity;
using LogicDeNegocio.Personas;
using Microsoft.Extensions.Logging;
using Unity.Lifetime;
using LogicDeNegocio.Requests;
namespace LogicDeNegocio.Configuration
{
    public static class LogicDeNegocioConfig
    {
        public static IUnityContainer RegisterTypes(this IUnityContainer container)
        {
            /// Registrar Servicio de Usuarios
            container.RegisterType<IUsuarioService, UsuarioService>();
            /// Registrar Servicio de Servicios
            container.RegisterType<IServicioService, ServicioService>();
            // Registrar AutoMapper
            var mapper = AutoMapperConfig.Initialize();
            container.RegisterInstance(mapper);
            // Register FluentValidation validators
            container.RegisterType<IValidator<UsuarioRequest>, UsuarioValidator>();
            // Registro de ILogger en Unity
            container.RegisterType<ILoggerFactory, LoggerFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));

            container.RegisterType<IAtributoProductoService, AtributoProductoService>();
            container.RegisterType<IAtributoService, AtributoService>();
            container.RegisterType<IBancoService, BancoService>();
            container.RegisterType<ICategoriaAtributoService, CategoriaAtributoService>();
            container.RegisterType<ICategoriaProductoService, CategoriaProductoService>();
            container.RegisterType<ICiudadService, CiudadService>();
            container.RegisterType<IClienteService, ClienteService>();
            container.RegisterType<ICuentaService, CuentaService>();
            container.RegisterType<IEmpleadoService, EmpleadoService>();
            container.RegisterType<IEmpresaService, EmpresaService>();
            container.RegisterType<IEventoService, EventoService>();
            container.RegisterType<IFormaPagoService, FormaPagoService>();
            container.RegisterType<IInventarioService, InventarioService>();
            container.RegisterType<ILoginService, LoginService>();
            container.RegisterType<IPasswordHashService, PasswordHashService>();
            container.RegisterType<IPersonaService, PersonaService>();
            container.RegisterType<IPresupuestoDetalleService, PresupuestoDetalleService>();
            container.RegisterType<IPresupuestoService, PresupuestoService>();
            container.RegisterType<IProductoService, ProductoService>();
            container.RegisterType<IProveedorService, ProveedorService>();
            container.RegisterType<IProvinciaService, ProvinciaService>();
            container.RegisterType<IRolService, RolService>();
            container.RegisterType<IServicioService, ServicioService>();
            container.RegisterType<ITipoCuentaService, TipoCuentaService>();
            container.RegisterType<ITipoEmpresaService, TipoEmpresaService>();
            container.RegisterType<ITipoProductoService, TipoProductoService>();
            container.RegisterType<ITipoServicioService, TipoServicioService>();
            container.RegisterType<IUsuarioService, UsuarioService>();
            return container;


        }
    }
}
