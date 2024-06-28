using Datos;
using LogicDeNegocio.personas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class Ciudad
    {
        MySqlConnection con = new MySqlConnection();

        private int idciudad;
        private String descripcion;
        private int idProvincia;

        public Ciudad() { }
        public Ciudad(int idciudad, string ciudad)
        {
            this.idciudad = idciudad;
            this.descripcion = ciudad;
        }
        public Ciudad(string ciudad, int idprovincia) 
        {
            this.descripcion = ciudad;
            this.idProvincia = idprovincia;
        }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public int Idciudad { get => idciudad; set => idciudad = value; }

        public override string ToString() 
        { 
            return descripcion;
        }

        public void InsertarCiudad(Ciudad c)
        {
            List<Ciudad> ListCiud = new List<Ciudad>();
            ListCiud.Add(c);
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("InsertarCiudad", con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Ciudad ciudad in ListCiud)
                {
                    cmd.Parameters.AddWithValue("@c_descripcion", ciudad.Descripcion);
                    cmd.Parameters.AddWithValue("@idprov", ciudad.IdProvincia);
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

        public List<Ciudad> llenarComboCiudad()
        {
            List<Ciudad> ListCiudad = new List<Ciudad>();
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("llenarComboCiudad", con);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ciudad ciudad = new Ciudad(Convert.ToInt32(reader["idciudad"].ToString()), reader["descripcion"].ToString());
                    ListCiudad.Add(ciudad);
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
            return ListCiudad;
        }

    }
}
