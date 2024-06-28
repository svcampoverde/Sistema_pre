using MySql.Data.MySqlClient;
using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicDeNegocio.provincia;

namespace LogicDeNegocio.personas
{
    public class Usuario : Persona
    {
        MySqlConnection con =new MySqlConnection();
        private String user;
        private String clave;
        //private Ciudad ciudad;
        //private Rol rol;
        private int idciudad;
        private int idrol;

        public Usuario(string cedula, string nombre, string apellido, string genero, string telefono, string celular, string correo, string direccion, int idciudad, int idrol, string user, string clave)
            :base(cedula, nombre, apellido, genero, telefono, celular, correo,  direccion)
        {
            this.user = user;
            this.clave = clave;
            this.idciudad = idciudad;
            this.idrol = idrol;
        }

        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }
        //public Rol Rol { get => rol; set => rol = value; }
        //public Ciudad Ciudad { get => ciudad; set => ciudad = value; }
        public int IdCiudad { get => idciudad; set => idciudad = value; }
        public int IdRol { get => idrol; set => idrol = value; }

        public void InsertarUsuario(Usuario us) 
        {
            List<Usuario> listUsuario = new List<Usuario>();
            listUsuario.Add(us);
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("RegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Usuario user in listUsuario )
                {
                    cmd.Parameters.AddWithValue("@Cedulap", user.cedula);
                    cmd.Parameters.AddWithValue("@Nombrep", user.nombre);
                    cmd.Parameters.AddWithValue("@Apellidop", user.apellido);
                    cmd.Parameters.AddWithValue("@Generop", user.genero);
                    cmd.Parameters.AddWithValue("@Telefonop", user.telefono);
                    cmd.Parameters.AddWithValue("@Celularp", user.celular);
                    cmd.Parameters.AddWithValue("@Correop", user.correo);
                    cmd.Parameters.AddWithValue("@Direccionp", user.direccion);
                    cmd.Parameters.AddWithValue("@idciud", user.idciudad);
                    cmd.Parameters.AddWithValue("@usp", user.user);
                    cmd.Parameters.AddWithValue("@clavep", user.clave);
                    cmd.Parameters.AddWithValue("@idrolp", user.idrol);
                }
                cmd.ExecuteReader();
            }catch (MySqlException ex)
            {
               throw ex;
            }
            finally
            {
                if(con.State == ConnectionState.Open) { con.Close(); }
            }
        }
    }

}
