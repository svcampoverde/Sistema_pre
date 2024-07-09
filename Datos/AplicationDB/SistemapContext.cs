
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

        public virtual DbSet<Atributo> Atributos { get; set; }
        public virtual DbSet<AtributoProducto> AtributoProductos { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<CategoriaAtributo> CategoriaAtributos { get; set; }
        public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<FormaPago> FormaPagos { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PresupuestoDetalle> PresupuestoDetalles { get; set; }
        public virtual DbSet<Presupuesto> Presupuestos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuentas { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresas { get; set; }
        public virtual DbSet<TipoProducto> TipoProductos { get; set; }
        public virtual DbSet<TipoServicio> TipoServicios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemapContext).Assembly);
  
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //public void Seed()
        //{
        //    var excel = @"Recursos\FileExcelSeeder\ProvinciasCiudades.xlsx";
        //    if (!Provincias.Any())
        //    {
        //        Provincias.AddRange(ExcelLoader.LoadProvinciasFromExcel(excel));
        //        SaveChanges();
        //    }

        //    if (!Ciudades.Any())
        //    {
        //        Ciudades.AddRange(ExcelLoader.LoadCiudadesFromExcel(excel));
        //        SaveChanges();
        //    }
        //}
    }
}
