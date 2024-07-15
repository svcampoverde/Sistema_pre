using Presentacion.ModuloCiudad;
using Presentacion.ModuloCliente;
using Presentacion.ModuloEmpleado;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloLogin;
using Presentacion.ModuloPago;
using Presentacion.ModuloPresupuesto;
using Presentacion.ModuloProducto;
using Presentacion.ModuloProveedor;
using Presentacion.ModuloProvincia;
using Presentacion.ModuloRolusuario;
using Presentacion.ModuloServicio;
using Presentacion.ModuloUsuario;

using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Presentacion.App_Start
{
    public static class ConfigForms
    {
        public static IUnityContainer RegisterForms(this IUnityContainer container)
        {
            container.RegisterType<Home>(new InjectionConstructor(typeof(IUnityContainer), typeof(FrmIPrincipal)));
            container.RegisterType<FrmRegistrarUsuario>(new TransientLifetimeManager());
            container.RegisterSingleton<FrmIPrincipal>();
            container.RegisterType<FrmRol>(new TransientLifetimeManager());
            container.RegisterType<FrmCiudad>(new TransientLifetimeManager());
            container.RegisterType<FrmBuscarUsuario>(new TransientLifetimeManager());
            container.RegisterType<FrmEmpleado>(new TransientLifetimeManager());
            container.RegisterType<FrmRegistrarCliente>(new TransientLifetimeManager());
            container.RegisterType<FrmEmpresa>(new TransientLifetimeManager());
            container.RegisterType<FrmTipoEmpresa>(new TransientLifetimeManager());
            container.RegisterType<FrmLogin>(new TransientLifetimeManager());
            container.RegisterType<FrmRecuperarContrasena>(new TransientLifetimeManager());
            container.RegisterType<FrmRegistrarCliente>(new TransientLifetimeManager());
            container.RegisterType<FrmListarPresupuesto>(new TransientLifetimeManager());
            container.RegisterType<FrmCategoria>(new TransientLifetimeManager());
            container.RegisterType<FrmRegistroProveedor>(new TransientLifetimeManager());
            container.RegisterType<FrmInventario>(new TransientLifetimeManager());
            container.RegisterType<FrmProvincia>(new TransientLifetimeManager());
            container.RegisterType<FrmFormaPago>(new TransientLifetimeManager());
            container.RegisterType<FrmEvento>(new TransientLifetimeManager());
            container.RegisterType<FrmTipoProducto>(new TransientLifetimeManager());
            container.RegisterType<FrmModificarUsuario>(new TransientLifetimeManager());
            return container;
        }

    }
}
