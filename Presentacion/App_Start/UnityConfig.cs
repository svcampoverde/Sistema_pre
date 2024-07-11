using Datos.AplicationDB;

using LogicDeNegocio.Configuration;

using Microsoft.EntityFrameworkCore;

using Presentacion.App_Start;

using System;
using System.Configuration;

using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Presentacion
{
    public static class UnityConfig
    {
        [Obsolete]
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            UnityContainer container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        [Obsolete]
        public static IUnityContainer Container => container.Value;

        [Obsolete]
        public static void RegisterTypes(IUnityContainer container)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SistemapContextConnection"].ConnectionString;

            //// Configurar Polly Retry Policy
            //var retryPolicy = Policy
            //    .Handle<MySqlException>()
            //    .WaitAndRetry(new[]
            //    {
            //        TimeSpan.FromSeconds(1),
            //        TimeSpan.FromSeconds(5),
            //        TimeSpan.FromSeconds(10)
            //    });
            DbContextOptionsBuilder<SistemapContext> optionsBuilder = new DbContextOptionsBuilder<SistemapContext>()
                .UseMySQL(connectionString, e =>
                {
                }).EnableServiceProviderCaching(true)
                .EnableDetailedErrors().EnableSensitiveDataLogging()
                ;

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