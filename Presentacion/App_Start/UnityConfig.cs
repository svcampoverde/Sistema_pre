using Datos.AplicationDB;
using LogicDeNegocio.Configuration;
using Microsoft.EntityFrameworkCore;
using Presentacion.ModuloProvincia;
using Presentacion.ModuloRolusuario;
using Presentacion.ModuloUsuario;
using Presentacion.Servicio;
using System;
using System.Web.UI.WebControls;
using Unity;
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
                .UseMySQL("Server=localhost;Database=sistemap;User=root;Password=Kawasaki2512;", e =>
                {
                    e.MigrationsAssembly(typeof(SistemapContext).Assembly.FullName);
                });

            // Registrar DbContextOptions para inyección de dependencias
            container.RegisterInstance(optionsBuilder.Options);

            // Registrar SistemapContext con ciclo de vida adecuado
            container.RegisterType<SistemapContext>();

            // Registrar otros servicios y formularios
            container.RegisterType<BuscarRol>();
            container.RegisterType<FrmRegistrarUsuario>();
            container.RegisterType<FRMPrincipal>();
            container.RegisterType<FRMRol>();
            container.RegisterType<FrmModificarRol>();
            container.RegisterType<FrmBuscarProvincia>();
            container.RegisterType<FrmProvincia>();
            container.RegisterType<Login>();
            container.RegisterType<BuscarUsuario>();
            container.RegisterType<FrmServicio>();
            container.RegisterTypes();
        }

    }
}

