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
            optionsBuilder.UseMySQL("Server=localhost;Database=sistemap;User=root;Password=Kawasaki2512;",
                sql =>
                {
                    sql.MigrationsAssembly(typeof(SistemapContextFactory).Assembly.FullName);
                });

          

            return new SistemapContext(optionsBuilder.Options);
        }
    }
}
