using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using MySqlConnector;

namespace LogicDeNegocio.personas
{
    public class UsuarioDao
    {
      //  MySqlDataReader resultado;
    //    DataTable tabla = new DataTable();
        MySqlConnection con = new MySqlConnection();
        private static string cedula = "";

        public static string getCedula()
        {
            return cedula;
        }

        public static void setCedula(string cedulas)
        {
            cedula = cedulas;
        }
        public bool ValidarUsuario(string us)
        {
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("validarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@usrc", MySqlDbType.VarChar).Value = us;

                cmd.Parameters.Add("@existe", MySqlDbType.Int32).Direction = ParameterDirection.Output;
               
                cmd.ExecuteNonQuery();
                int  respuesta = (int)cmd.Parameters["@existe"].Value;
                return respuesta == 1;

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
        public List<int> Credenciales(string usuario, string clave)
        {
            List<int> IdPeronsaAndRol = new List<int>();
            List<string> IdCedula = new List<string>();
            try
            {
             
                con = new Conexion().Conectar();
                MySqlCommand cmd = new MySqlCommand("spl_validarcredencial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usr", usuario);
                cmd.Parameters.AddWithValue("@pass", clave);
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    int x = Convert.ToInt32(lector["idrol"]);
                    IdPeronsaAndRol.Add(Convert.ToInt32(lector["idrol"]));
                    if (x == 1)//|| x == 3)
                    {
                        IdPeronsaAndRol.Add(Convert.ToInt32(lector["idpersona"]));
                    }
                    else
                    {
                        IdCedula.Add(Convert.ToString(lector["cedula"]));
                        setCedula(IdCedula[0]);
                    }
                }
               // con.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            finally { if (con.State == ConnectionState.Open) { con.Close(); } }
            return IdPeronsaAndRol;
        }
        public bool ValidarCredencial(string usuario, string clave)
        {
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("ValidarCredencial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = clave;
                
                cmd.Parameters.Add("@resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
               
                cmd.ExecuteNonQuery();
                int resultadoProcedimiento = (int)cmd.Parameters["@resultado"].Value;

                if (resultadoProcedimiento == 1)
                {
                    return true;
                }
              
                else
                {
                    return false;
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { if (con.State == ConnectionState.Open) { con.Close(); } }

        }

        public bool InsertUsuario(Usuario us) 
        {
            Usuario registro = us;
            registro.InsertarUsuario(registro);
            return true;
        }
       
    }
}
