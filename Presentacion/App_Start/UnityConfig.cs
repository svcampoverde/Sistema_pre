using Datos.AplicationDB;

using LogicDeNegocio.Configuration;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Personas;
using LogicDeNegocio.Services;

using Microsoft.EntityFrameworkCore;

using Presentacion.App_Start;
using Presentacion.ModuloCliente;
using Presentacion.ModuloEmpleado;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloProducto;
using Presentacion.ModuloProveedor;
using Presentacion.ModuloProvincia;
using Presentacion.ModuloRolusuario;
using Presentacion.ModuloServicio;
using Presentacion.ModuloUsuario;
using System;
using System.Web.UI.WebControls;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
namespace Presentacion
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container =
        new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        public static IUnityContainer Container => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SistemapContext>()
                .UseMySQL("Server=localhost;Database=sistemapresup;User=root;Password=admin;", e =>
                {
                    e.MigrationsAssembly(typeof(SistemapContext).Assembly.FullName);
                });

            // Registrar DbContextOptions para inyección de dependencias
            container.RegisterInstance(optionsBuilder.Options);

            // Registrar SistemapContext con ciclo de vida adecuado
            container.RegisterType<SistemapContext>();

            // Registrar otros servicios y formularios
            container.RegisterType<FrmRegistrarUsuario>();
            container.RegisterType<FrmIPrincipal>();
            container.RegisterType<FrmRol>();
            container.RegisterType<FrmProvincia>();
            container.RegisterType<Login>();
            container.RegisterType<FrmBuscarUsuario>();
            container.RegisterType<FrmEmpleado>();
            container.RegisterType<FrmCategoria>();
            container.RegisterType<FrmRegistroProveedor>();
            container.RegisterType<FrmServicio>();
            container.RegisterType<FrmRegistrarCliente>();
            container.RegisterType<FrmEmpresa>();
            container.RegisterType<FrmTipoEmpresa>();
            container.RegisterType<FrmInventario>();
            container.RegisterType<Home>(new InjectionConstructor(typeof(IUnityContainer), typeof(FrmIPrincipal)));


            container.RegisterTypes();
        }
    }
}
