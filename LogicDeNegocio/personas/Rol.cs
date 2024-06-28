using Datos;
using LogicDeNegocio.provincia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.personas
{
    public class Rol
    {
        MySqlConnection con = new MySqlConnection();

        private int idrol;
        private String rolUsuario;

        public Rol() { }
        public Rol(int idrol, string rolUsuario)
        {
            this.idrol = idrol;
            this.rolUsuario = rolUsuario;
        }
        public Rol(string rolUsuario) 
        {
            this.rolUsuario = rolUsuario;
        }
        public string RolUsuario { get => rolUsuario; set => rolUsuario = value; }
        public int Idrol { get => idrol; set => idrol = value; }

        public override string ToString()
        {
            return rolUsuario;
        }
        public void InsertarRol(Rol r)
        {
            List<Rol> ListRol = new List<Rol>();
            ListRol.Add(r);
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("spl_registrarRol", con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Rol rol in ListRol)
                {
                    cmd.Parameters.AddWithValue("@r_descripcion", rol.RolUsuario);
                }
                cmd.ExecuteReader();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public List<Rol> BuscarRol(string dato)
        {
            Rol rol = null;
            List<Rol> ListRol = new List<Rol>();

            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("ListarRol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Roles", dato);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rol = new Rol(Convert.ToInt32(reader["idrol"].ToString()), reader["descripcion"].ToString());
                    ListRol.Add(rol);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error emitido por: " + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return ListRol;
        }

        public List<Rol> llenarComboRol()
        {
            List<Rol> ListRol = new List<Rol>();
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("llenarComboRol", con);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Rol rol = new Rol(Convert.ToInt32(reader["idrol"].ToString()), reader["descripcion"].ToString());
                    ListRol.Add(rol);
                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return ListRol;
        }

    }

}
