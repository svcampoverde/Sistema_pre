﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Clientes = new HashSet<Cliente>();
            Proveedors = new HashSet<Proveedor>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } 
        public string Telefono { get; set; }
        public string Correo { get; set; } 
        public string Direccion { get; set; } 
         public string Estado { get; set; } ="A"; 
        public int Idtipoempresa { get; set; }

        public virtual Tipoempresa IdtipoempresaNavigation { get; set; } 
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}