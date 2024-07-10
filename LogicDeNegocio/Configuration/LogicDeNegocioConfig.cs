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
            container.RegisterType<IUsuarioService, UsuarioService>(new TransientLifetimeManager());
            /// Registrar Servicio de Servicios
            container.RegisterType<IServicioService, ServicioService>(new TransientLifetimeManager());
            // Registrar AutoMapper
            var mapper = AutoMapperConfig.Initialize();
            container.RegisterInstance(mapper);
            // Register FluentValidation validators
            container.RegisterType<IValidator<UsuarioRequest>, UsuarioValidator>(new TransientLifetimeManager());
            // Registro de ILogger en Unity
            container.RegisterType<ILoggerFactory, LoggerFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));

            container.RegisterType<IAtributoProductoService, AtributoProductoService>(new TransientLifetimeManager());
            container.RegisterType<IAtributoService, AtributoService>(new TransientLifetimeManager());
            container.RegisterType<IBancoService, BancoService>(new TransientLifetimeManager());
            container.RegisterType<ICategoriaAtributoService, CategoriaAtributoService>(new TransientLifetimeManager());
            container.RegisterType<ICategoriaProductoService, CategoriaProductoService>(new TransientLifetimeManager());
            container.RegisterType<ICiudadService, CiudadService>(new TransientLifetimeManager());
            container.RegisterType<IClienteService, ClienteService>(new TransientLifetimeManager());
            container.RegisterType<ICuentaService, CuentaService>(new TransientLifetimeManager());
            container.RegisterType<IEmpleadoService, EmpleadoService>(new TransientLifetimeManager());
            container.RegisterType<IEmpresaService, EmpresaService>(new TransientLifetimeManager());
            container.RegisterType<IEventoService, EventoService>(new TransientLifetimeManager());
            container.RegisterType<IFormaPagoService, FormaPagoService>(new TransientLifetimeManager());
            container.RegisterType<IInventarioService, InventarioService>(new TransientLifetimeManager());
            container.RegisterType<ILoginService, LoginService>(new TransientLifetimeManager());
            container.RegisterType<IPasswordHashService, PasswordHashService>(new TransientLifetimeManager());
            container.RegisterType<IPersonaService, PersonaService>(new TransientLifetimeManager());
            container.RegisterType<IPresupuestoDetalleService, PresupuestoDetalleService>(new TransientLifetimeManager());
            container.RegisterType<IPresupuestoService, PresupuestoService>(new TransientLifetimeManager());
            container.RegisterType<IProductoService, ProductoService>(new TransientLifetimeManager());
            container.RegisterType<IProveedorService, ProveedorService>(new TransientLifetimeManager());
            container.RegisterType<IProvinciaService, ProvinciaService>(new TransientLifetimeManager());
            container.RegisterType<IRolService, RolService>(new TransientLifetimeManager());
            container.RegisterType<IServicioService, ServicioService>(new TransientLifetimeManager());
            container.RegisterType<ITipoCuentaService, TipoCuentaService>(new TransientLifetimeManager());
            container.RegisterType<ITipoEmpresaService, TipoEmpresaService>(new TransientLifetimeManager());
            container.RegisterType<ITipoProductoService, TipoProductoService>(new TransientLifetimeManager());
            container.RegisterType<ITipoServicioService, TipoServicioService>(new TransientLifetimeManager());
            container.RegisterType<IUsuarioService, UsuarioService>(new TransientLifetimeManager());
            return container;


        }
    }
}
