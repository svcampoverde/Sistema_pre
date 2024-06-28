using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        string servidor;
        string db;
        string usuario;
        string contrasena;
        string puerto;

        public Conexion()
        {

            this.servidor = "localhost";
            this.db = "sistemap";
            this.usuario = "root";
            this.contrasena = "admin";
            this.puerto = "3306";
        }
        public MySqlConnection Conectar()
        {
            MySqlConnection conect = new MySqlConnection();
            try
            {
                conect.ConnectionString = "datasource=" + servidor +
                     ";user id=" + usuario +
                    ";port=" + puerto +
                     ";database=" + db +
                     ";password=" + contrasena +
                     //"; SslMode=none"+
                     ";";//SSL Model=" + ssl + ";";
                         //  conect.Open();

            }
            catch (MySqlException ex)
            {
                conect = null;
                throw ex;
                //  MessageBox.Show(ex.ToString());
            }
            return conect;

        }
    }
}
