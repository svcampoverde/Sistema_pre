
using Datos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading.Tasks;
using System.Threading;


namespace Datos.AplicationDB
{
    public partial class SistemapContext : DbContext
    {

        public SistemapContext(DbContextOptions<SistemapContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Atributo> Atributos { get; set; }
        public virtual DbSet<AtributoProducto> AtributoProductos { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<CategoriaAtributo> CategoriaAtributos { get; set; }
        public virtual DbSet<CategoriaBanco> CategoriaBancos { get; set; }
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
            UpdateBaseEntities();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateBaseEntities();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateBaseEntities()
        {
            // Obtener todas las entidades que han cambiado
            var entities = ChangeTracker.Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted)
                .ToList(); // Convertir a lista para evitar la excepción de colección modificada

            // Obtener la fecha actual en UTC
            DateTime now = DateTime.UtcNow;

            // Actualizar cada entidad según su estado
            foreach (var entityEntry in entities)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        entityEntry.Entity.FechaCreacionUTC = now;
                        entityEntry.Entity.Activo = true; // Al agregar, siempre activo
                        break;
                    case EntityState.Modified:
                        entityEntry.Entity.FechaModificacionUTC = now;
                        break;
                    case EntityState.Deleted:
                        // Cambiar el estado a Modified para evitar la eliminación física
                        entityEntry.State = EntityState.Modified;
                        entityEntry.Entity.FechaModificacionUTC = now;
                        entityEntry.Entity.Activo = false; // Al eliminar, se desactiva
                        break;
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemapContext).Assembly);
  
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
