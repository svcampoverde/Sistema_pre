using Datos.AplicationDB;

using LogicDeNegocio.Configuration;
using LogicDeNegocio.Interfaces;
using LogicDeNegocio.Personas;
using LogicDeNegocio.Services;

using Microsoft.EntityFrameworkCore;

using Presentacion.App_Start;

using System;

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
            var optionsBuilder = new DbContextOptionsBuilder<SistemapContext>();
            optionsBuilder.UseMySQL("Server=localhost;Database=sistemap;User=root;Password=Kawasaki2512;",
                                    sql => sql.MigrationsAssembly(typeof(SistemapContext).Assembly.FullName));
            container.RegisterType<DbContextOptions<SistemapContext>>(
            new InjectionFactory(_ =>
            { 
                return optionsBuilder.Options;
            }));
            

            container.RegisterType<SistemapContext>(new HierarchicalLifetimeManager(),
                                                    new InjectionFactory(c => new SistemapContext(optionsBuilder.Options)));

            container.RegisterType<SistemapContext>(new TransientLifetimeManager());
            container.RegisterType<Func<SistemapContext>>(new InjectionFactory(c => new Func<SistemapContext>(() => c.Resolve<SistemapContext>())));
            container.RegisterTypes().RegisterForms();
        }
    }
}
