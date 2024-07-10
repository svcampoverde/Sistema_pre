using Presentacion.ModuloCiudad;
using Presentacion.ModuloCliente;
using Presentacion.ModuloEmpleado;
using Presentacion.ModuloEmpresa;
using Presentacion.ModuloLogin;
using Presentacion.ModuloPresupuesto;
using Presentacion.ModuloProducto;
using Presentacion.ModuloProveedor;
using Presentacion.ModuloProvincia;
using Presentacion.ModuloRolusuario;
using Presentacion.ModuloUsuario;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;
using Unity.Lifetime;

namespace Presentacion.App_Start
{
    public static class ConfigForms
    {
        public static IUnityContainer RegisterForms(this IUnityContainer container)
        {
            container.RegisterType<FrmRegistrarUsuario>(new TransientLifetimeManager());
            container.RegisterType<FrmIPrincipal>(new TransientLifetimeManager());
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
            container.RegisterType<FrmModificarUsuario>(new TransientLifetimeManager());
            return container;
        }

    }
}
