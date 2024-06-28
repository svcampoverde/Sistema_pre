using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.personas
{
    public class Persona
    {
        protected String cedula;
        protected String nombre;
        protected String apellido;
        protected String genero;
        protected String telefono;
        protected String celular;
        protected String correo;
        protected String direccion;

        public Persona(string cedula, string nombre, string apellido, string genero, string telefono, string celular, string correo, string direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.telefono = telefono;
            this.celular = celular;
            this.correo = correo;
            this.direccion = direccion;
        }
        public String getCedula() {  return cedula; }
        public String getNombre() {  return nombre; }
        public String getApellido() { return apellido; }
        public String getGenero() { return genero; }
        public String getTelefono() {  return telefono; }
        public String getCelular() { return celular; }
        public String getCorreo() {  return correo; }
        public String getDireccion() {  return direccion; }
        public void setCedula(String cedula) { this.cedula = cedula; }
        public void setNombre(String nombre) { this.nombre = nombre;}
        public void setGenero(String genero) {  this.genero = genero; }
        public void setTelefono(String telefono) { this.telefono = telefono; }
        public void setCorreo(String correo) { this.correo = correo; }
        public void setDireccion(String direccion) { this.direccion = direccion; }


    }
}
