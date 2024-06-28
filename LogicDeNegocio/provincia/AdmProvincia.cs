using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class AdmProvincia
    {
        Provincia provin = new Provincia();
        public List<Provincia> ConsultarProvincia(string dato)
        {
            List<Provincia> provincia = null;
            provincia = provin.BuscarProvincia(dato);
            if (provincia.Count == 0)
            {
                throw new ExceptionSistema("No se encontraron registros");
            }
            return provincia;
        }
        public bool insertarProvincia(Provincia pro)
        {
            Provincia registro = pro;
            registro.insertarProvincia(registro);
            return true;
        }
    }
}
