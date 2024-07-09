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

namespace Presentacion.App_Start
{
    public static class ConfigForms
    {
        public static IUnityContainer RegisterForms(this IUnityContainer container)
        {
            container.RegisterType<FrmRegistrarUsuario>();
            container.RegisterType<FrmIPrincipal>();
            container.RegisterType<FrmRol>();
            container.RegisterType<FrmCiudad>();
            container.RegisterType<FrmBuscarUsuario>();
            container.RegisterType<FrmEmpleado>();
            container.RegisterType<FrmRegistrarCliente>();
            container.RegisterType<FrmEmpresa>();
            container.RegisterType<FrmTipoEmpresa>();
            container.RegisterType<FrmLogin>();
            container.RegisterType<FrmRecuperarContrasena>();
            container.RegisterType<FrmRegistrarCliente>();
            container.RegisterType<FrmListarPresupuesto>();
            container.RegisterType<FrmCategoria>();
            container.RegisterType<FrmRegistroProveedor>();
            container.RegisterType<FrmInventario>();
            container.RegisterType<FrmProvincia>();
            container.RegisterType<FrmModificarUsuario>();
            return container;
        }

    }
}
