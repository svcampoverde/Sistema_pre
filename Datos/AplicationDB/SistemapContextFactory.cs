using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Datos.AplicationDB
{
    public class SistemapContextFactory : IDesignTimeDbContextFactory<SistemapContext>
    {
        public SistemapContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SistemapContext>();

            // Configuración de MySQL
            optionsBuilder.UseMySQL("Server=localhost;Database=sistemapresup;User=root;Password=admin;",
                sql =>
                {
                    sql.MigrationsAssembly(typeof(SistemapContextFactory).Assembly.FullName);
                });

          

            return new SistemapContext(optionsBuilder.Options);
        }
    }
}
