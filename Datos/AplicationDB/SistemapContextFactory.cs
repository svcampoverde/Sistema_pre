using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System.Configuration;

namespace Datos.AplicationDB
{
    public class SistemapContextFactory : IDesignTimeDbContextFactory<SistemapContext>
    {
        public SistemapContext CreateDbContext(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SistemapContextConnection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<SistemapContext>()
                .UseMySql(connectionString, e =>
                {

                    e.MigrationsAssembly(typeof(SistemapContext).Assembly.FullName);
                }).EnableDetailedErrors().EnableSensitiveDataLogging().EnableServiceProviderCaching();
            return new SistemapContext(optionsBuilder.Options);
        }
    }
}
