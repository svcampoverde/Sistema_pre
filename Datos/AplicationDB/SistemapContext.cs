
using Datos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;


namespace Datos.AplicationDB
{
    public partial class SistemapContext : DbContext
    {

        public SistemapContext(DbContextOptions<SistemapContext> options)
            : base(options)
        {
            Database.Migrate();

        }

        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Presupuesto> Cabpresupuestos { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Ciudad> Ciudads { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<PresupuestoDetalle> Detpresupuestos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoCuenta> Tipocuenta { get; set; }
        public virtual DbSet<TipoEmpresa> Tipoempresas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemapContext).Assembly);
  
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                ((BaseEntity)entity.Entity).FechaModificacionUTC = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        //public void Seed()
        //{
        //    var excel = @"Recursos\FileExcelSeeder\ProvinciasCiudades.xlsx";
        //    if (!Provincias.Any())
        //    {
        //        Provincias.AddRange(ExcelLoader.LoadProvinciasFromExcel(excel));
        //        SaveChanges();
        //    }

        //    if (!Ciudads.Any())
        //    {
        //        Ciudads.AddRange(ExcelLoader.LoadCiudadesFromExcel(excel));
        //        SaveChanges();
        //    }
        //}
    }
}
