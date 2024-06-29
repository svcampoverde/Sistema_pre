﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;

namespace Datos.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Clientes = new HashSet<Cliente>();
            Empleados = new HashSet<Empleado>();
            Proveedors = new HashSet<Proveedor>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Cedula { get; set; } 
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; } 
        public string Direccion { get; set; } 
         public string Estado { get; set; } ="A"; 
        public int Idciudad { get; set; }

        public virtual Ciudad IdciudadNavigation { get; set; } 
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}