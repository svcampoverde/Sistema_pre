﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Proveedor
    {
        public int Id { get; set; }
        public int Idpersona { get; set; }
        public string Empresa { get; set; } 
        public string Tiposervicio { get; set; } 
        public int Idciudad { get; set; }
        public int Idservicio { get; set; }
        public int Idcuenta { get; set; }
        public int Idpago { get; set; }
        public int Idempresa { get; set; }

        public virtual Ciudad IdciudadNavigation { get; set; } 
        public virtual Cuentum IdcuentaNavigation { get; set; } 
        public virtual Empresa IdempresaNavigation { get; set; } 
        public virtual Pago IdpagoNavigation { get; set; } 
        public virtual Persona IdpersonaNavigation { get; set; } 
        public virtual Servicio IdservicioNavigation { get; set; } 
    }
}